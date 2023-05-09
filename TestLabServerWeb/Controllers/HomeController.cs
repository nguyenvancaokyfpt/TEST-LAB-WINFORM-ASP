using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestLabServerWeb.Models;
using TestLabLibrary.Repository;
using TestLabEntity.AutoDB;
using System.Drawing.Printing;

namespace TestLabServerWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IStudentRepository _studentRepository;
        IPaperRepository _paperRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
            _paperRepository = new PaperRepository();
        }

        public IActionResult Index()
        {
            var isDoExam = HttpContext.Session.GetString("isDoExam");
            if (isDoExam == "true")
            {
                return RedirectToAction("Index", "DoExam");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            var isDoExam = HttpContext.Session.GetString("isDoExam");
            if (isDoExam == "true")
            {
                return RedirectToAction("Index", "DoExam");
            }
            else
            {
                return View();
            }
        }

        // POST:
        [HttpPost]
        public IActionResult Index(string username, string password, string examcode)
        {
            if (username != null && password != null && examcode != null)
            {
                try
                {
                    var student = _studentRepository.Login(username, password);
                    if (student == true)
                    {
                        // Get Paper
                        var paper = _paperRepository.GetPaper(examcode);
                        var user = _studentRepository.GetStudent(username);
                        if (paper != null && user != null)
                        {
                            if (paper.IsOpen == true)
                            {
                                // Get SubmitPaper
                                TlSubmitpaper? submitPaper = new TlSubmitpaper();
                                submitPaper = _paperRepository.GetSubmitPaperByStudent(user.Id, paper.Id);
                                if (submitPaper == null)
                                {
                                    // Create new SubmitPaper
                                    var newSubmitPaper = new TlSubmitpaper();
                                    newSubmitPaper.PaperId = paper.Id;
                                    newSubmitPaper.StudentId = user.Id;
                                    newSubmitPaper.Mark = 0;
                                    newSubmitPaper.StartTime = DateTime.Now;
                                    _paperRepository.UpdatePaper(paper);
                                    try
                                    {
                                        submitPaper = _paperRepository.AddSubmitPaper(newSubmitPaper);
                                        // set session
                                        HttpContext.Session.SetString("username", username);
                                        HttpContext.Session.SetString("examcode", examcode);
                                        HttpContext.Session.SetString("isDoExam", "true");
                                        return RedirectToAction("Index", "DoExam");
                                    }
                                    catch
                                    {
                                        ViewBag.Message = "Server Error";
                                        return View();
                                    }
                                } else
                                {
                                    if (submitPaper.UpdateAt == null)
                                    {
                                        ViewBag.Message = "Exam is doing";
                                        return View();
                                    } else
                                    {
                                        ViewBag.Message = "Exam is done";
                                        return View();
                                    }
                                }
                            }
                            else
                            {
                                ViewBag.Message = "Exam is not open";
                                return View();
                            }
                        }
                        else
                        {
                            ViewBag.Message = "Exam code is not correct!";
                            return View();
                        }
                    }
                    else
                    {
                        // Set error message
                        ViewBag.Message = "Username or password is incorrect";
                        return View();
                    }
                }
                catch (Exception ex)
                {
                    // Set error message
                    ViewBag.Message = ex.Message;
                    return View();
                }
            }
            else
            {
                // Set error message
                ViewBag.Message = "Please enter username, password and examcode";
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}