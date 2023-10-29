using Microsoft.AspNetCore.Mvc;
using TestLabEntity.AutoDB;
using TestLabLibrary.Repository;

namespace TestLabServerWeb.Controllers
{
    public class DoExamController : Controller
    {
        IPaperRepository _paperRepository = new PaperRepository();
        IQuestionRepository _questionRepository = new QuestionRepository();
        IStudentRepository _studentRepository = new StudentRepository();
        public IActionResult Index()
        {
            // Get session
            var username = HttpContext.Session.GetString("username");
            var examcode = HttpContext.Session.GetString("examcode");
            var isDoExam = HttpContext.Session.GetString("isDoExam");
            if (isDoExam == "true" && username != null && examcode != null)
            {
                TlPaper? paper = _paperRepository.GetPaper(examcode);
                var user = _studentRepository.GetStudent(username);

                if (paper != null)
                {
                    List<TlQuestion> questions = _questionRepository.GetQuestionsByPaperId(paper.Id);
                    if (questions != null && user != null)
                    {
                        // Get SubmitPaper
                        var submitPaper = _paperRepository.GetSubmitPaperByStudent(user.Id, paper.Id);
                        if (submitPaper != null)
                        {
                            // end time = start time + duration
                            // time remaining = end time - current time
                            if (submitPaper.StartTime == null)
                            {
                                submitPaper.StartTime = DateTime.Now;
                            }
                            var remainingTime = submitPaper.StartTime.Value.AddMinutes(paper.Duration) - DateTime.Now;
                            // get seconds
                            var seconds = remainingTime.TotalSeconds;
                            ViewData["Paper"] = paper;
                            ViewBag.Username = username;
                            ViewBag.Duration = seconds;
                            ViewBag.userid = user.Id;
                            ViewBag.Paperid = paper.Id;
                            List<TlSubmitpaperDetail> submitpaperDetails = _paperRepository.GetSubmitPaperDetails(user.Id, paper.Id);
                            ViewData["PaperDetail"] = submitpaperDetails;
                            return View(questions);
                        }
                        else
                        {
                            ViewBag.Message = "You have not started the exam yet!";
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.Message = "No question in this paper";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "No paper";
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // API POST:
        // Select answer
        // Parameter: paperid, questionid, answerid
        // Status: 200 OK, 400 Error
        [HttpPost]
        public IActionResult SelectAnswer(int paperid, int questionid, int answerid)
        {
            var isDoExam = HttpContext.Session.GetString("isDoExam");
            var username = HttpContext.Session.GetString("username");
            var user = new TlStudent();
            if (username != null)
            {
                user = _studentRepository.GetStudent(username);
            }
            else
            {
                return BadRequest();
            }
            if (isDoExam == "true" && user != null)
            {
                // Get SubmitPaper
                var submitPaper = _paperRepository.GetSubmitPaperByStudent(user.Id, paperid);
                if (submitPaper == null)
                {
                    // Create new SubmitPaper
                    var newSubmitPaper = new TlSubmitpaper();
                    newSubmitPaper.PaperId = paperid;
                    newSubmitPaper.StudentId = user.Id;
                    newSubmitPaper.Mark = 0;
                    try
                    {
                        submitPaper = _paperRepository.AddSubmitPaper(newSubmitPaper);
                    }
                    catch
                    {

                    }
                }
                // add answer to SubmitPaperDetail
                if (submitPaper != null)
                {
                    var submitPaperDetail = new TlSubmitpaperDetail();
                    submitPaperDetail.SubmitpaperId = submitPaper.Id;
                    submitPaperDetail.QuestionId = questionid;
                    submitPaperDetail.AnswerId = answerid;
                    try
                    {
                        bool f = _paperRepository.AddSubmitPaperDetail(submitPaperDetail);
                        if (f)
                        {
                            return Ok();
                        }
                        else
                        {
                            return BadRequest();
                        }
                    }
                    catch
                    {
                        return BadRequest();
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        // API POST:
        // UnSelect answer
        // Parameter: paperid, questionid, answerid
        // Status: 200 OK, 400 Error
        [HttpPost]
        public IActionResult UnSelectAnswer(int paperid, int questionid, int answerid)
        {
            var isDoExam = HttpContext.Session.GetString("isDoExam");
            var username = HttpContext.Session.GetString("username");
            var user = new TlStudent();
            if (username != null)
            {
                user = _studentRepository.GetStudent(username);
            }
            else
            {
                return BadRequest();
            }
            if (isDoExam == "true" && user != null)
            {
                // Get SubmitPaper
                var submitPaper = _paperRepository.GetSubmitPaperByStudentUsername(username, paperid);
                if (submitPaper != null)
                {
                    // Delete answer from SubmitPaperDetail
                    try
                    {
                        bool f = _paperRepository.DeleteSubmitPaperDetail(submitPaper.Id, questionid, answerid);
                        if (f)
                        {
                            return Ok();
                        }
                        else
                        {
                            return BadRequest();
                        }
                    }
                    catch
                    {
                        return BadRequest();
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        // API POST:
        // SubmitPaper
        // Parameter: paperid
        // Status: 200 OK, 400 Error
        [HttpPost]
        public IActionResult SubmitPaper(int paperid)
        {
            var isDoExam = HttpContext.Session.GetString("isDoExam");
            var username = HttpContext.Session.GetString("username");
            if (isDoExam == "true" && username != null)
            {
                var user = _studentRepository.GetStudent(username);
                if (user != null)
                {
                    // Get SubmitPaper
                    var submitPaper = _paperRepository.GetSubmitPaperByStudentUsername(username, paperid);
                    if (submitPaper == null)
                    {
                        // Create new SubmitPaper
                        var newSubmitPaper = new TlSubmitpaper();
                        newSubmitPaper.PaperId = paperid;
                        newSubmitPaper.StudentId = user.Id;
                        newSubmitPaper.Mark = 0;
                        newSubmitPaper.UpdateAt = DateTime.Now;
                        try
                        {
                            submitPaper = _paperRepository.AddSubmitPaper(newSubmitPaper);
                            SetMark(submitPaper);
                            // Delete session
                            HttpContext.Session.Remove("isDoExam");
                            HttpContext.Session.Remove("examcode");
                            HttpContext.Session.Remove("username");
                            return Ok();
                        }
                        catch
                        {
                            return BadRequest();
                        }
                    }
                    else
                    {
                        submitPaper.UpdateAt = DateTime.Now;
                        try
                        {
                            _paperRepository.UpdateSubmitPaper(submitPaper);
                            SetMark(submitPaper);
                            // Delete session
                            HttpContext.Session.Remove("isDoExam");
                            HttpContext.Session.Remove("examcode");
                            HttpContext.Session.Remove("username");
                            return Ok();
                        }
                        catch
                        {
                            return BadRequest();
                        }
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        public void SetMark(TlSubmitpaper submitPaper)
        {
            List<TlQuestion> questions = _questionRepository.GetQuestionsByPaperId(submitPaper.PaperId);
            List<TlSubmitpaperDetail> submitPaperDetails = _questionRepository.GetSubmitPaperDetails(submitPaper.Id);
            double mark = 0;
            foreach (var question in questions)
            {
                var submitPaperDetail = submitPaperDetails.Where(x => x.QuestionId == question.Id).FirstOrDefault();
                if (submitPaperDetail != null)
                {
                    int count = 0;
                    int countCorrect = 0;
                    foreach (var answer in question.TlAnswers)
                    {
                        if (answer.IsCorrect == true)
                        {
                            count++;
                        }
                        if (answer.Id == submitPaperDetail.AnswerId)
                        {
                            if (answer.IsCorrect == true)
                            {
                                countCorrect++;
                            }
                        }
                    }
                    if (count == countCorrect)
                    {
                        mark++;
                    }
                }
            }
            submitPaper.Mark = (mark / questions.Count) * 10.0;
            _paperRepository.UpdateSubmitPaper(submitPaper);
        }
    }
}
