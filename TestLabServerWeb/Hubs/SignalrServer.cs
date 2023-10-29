using Microsoft.AspNetCore.SignalR;
using System.Drawing.Printing;
using TestLabEntity.AutoDB;
using TestLabLibrary.Repository;

namespace TestLabServerWeb.Hubs
{
    public class SignalrServer : Hub
    {
        IPaperRepository _paperRepository = new PaperRepository();
        IQuestionRepository _questionRepository = new QuestionRepository();
        IStudentRepository _studentRepository = new StudentRepository();
        public void Hello(string message)
        {
            Clients.All.SendAsync("Hello from server", message);
        }

        public void SelectAnswer(string userIdStr, string paperIdStr, string questionIdStr, string answerIdStr)
        {
            int userId = int.Parse(userIdStr);
            int paperId = int.Parse(paperIdStr);
            int questionId = int.Parse(questionIdStr);
            int answerId = int.Parse(answerIdStr);
            // Get SubmitPaper
            var submitPaper = _paperRepository.GetSubmitPaperByStudent(userId, paperId);
            if (submitPaper == null)
            {
                // Create new SubmitPaper
                var newSubmitPaper = new TlSubmitpaper();
                newSubmitPaper.PaperId = paperId;
                newSubmitPaper.StudentId = userId;
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
                submitPaperDetail.QuestionId = questionId;
                submitPaperDetail.AnswerId = answerId;
                try
                {
                    bool f = _paperRepository.AddSubmitPaperDetail(submitPaperDetail);
                    if (f)
                    {
                        // return Ok to this client
                        Clients.Caller.SendAsync("SaveAnswerResult", 1, answerId);
                    }
                    else
                    {
                        Clients.Caller.SendAsync("SaveAnswerResult", 0, answerId);
                    }
                }
                catch
                {
                    Clients.Caller.SendAsync("SaveAnswerResult", 0, answerId);
                }
            }
            else
            {
                Clients.Caller.SendAsync("SaveAnswerResult", 0, answerId);
            }
        }

        public void UnSelectAnswer(string userIdStr, string paperIdStr, string questionIdStr, string answerIdStr)
        {
            int userId = int.Parse(userIdStr);
            int paperId = int.Parse(paperIdStr);
            int questionId = int.Parse(questionIdStr);
            int answerId = int.Parse(answerIdStr);
            // Get SubmitPaper
            var submitPaper = _paperRepository.GetSubmitPaperByStudent(userId, paperId);
            if (submitPaper != null)
            {
                // Delete answer from SubmitPaperDetail
                try
                {
                    bool f = _paperRepository.DeleteSubmitPaperDetail(submitPaper.Id, questionId, answerId);
                    if (f)
                    {
                        Clients.Caller.SendAsync("SaveAnswerResult", 0, answerId);
                    }
                    else
                    {
                        Clients.Caller.SendAsync("SaveAnswerResult", 0, answerId);
                    }
                }
                catch
                {
                    Clients.Caller.SendAsync("SaveAnswerResult", 0, answerId);
                }
            }
            else
            {
                Clients.Caller.SendAsync("SaveAnswerResult", 0, answerId);
            }
        }
    }
}
