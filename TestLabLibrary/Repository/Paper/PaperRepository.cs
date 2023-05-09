using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;
using TestLabLibrary.DataAccess.Paper;

namespace TestLabLibrary.Repository
{
    public class PaperRepository : IPaperRepository
    {
        // Paper
        List<TlPaper> IPaperRepository.GetPapers() => PaperDAO.Instance.GetPapers();
        List<TlPaper> IPaperRepository.GetPapers(int offset, int limit, string search) => PaperDAO.Instance.GetPapers(offset, limit, search);
        TlPaper? IPaperRepository.GetPaper(int id) => PaperDAO.Instance.GetPaper(id);
        TlPaper? IPaperRepository.GetPaper(string code) => PaperDAO.Instance.GetPaper(code);
        int IPaperRepository.AddPaper(TlPaper paper) => PaperDAO.Instance.AddPaper(paper);
        bool IPaperRepository.UpdatePaper(TlPaper paper) => PaperDAO.Instance.UpdatePaper(paper);
        bool IPaperRepository.DeletePaper(int id) => PaperDAO.Instance.DeletePaper(id);
        bool IPaperRepository.DeletePaper(string code) => PaperDAO.Instance.DeletePaper(code);
        // Paper Question
        List<TlQuestionPaper> IPaperRepository.GetQuestionPapers(int paper_id) => QuestionPaperDAO.Instance.GetQuestionPapers(paper_id);
        List<TlQuestionPaper> IPaperRepository.GetQuestionPapers(int offset, int limit, int qid, int pid) => QuestionPaperDAO.Instance.GetQuestionPapers(offset, limit, qid, pid);
        TlQuestionPaper? IPaperRepository.GetQuestionPapersByPaperId(int pid) => QuestionPaperDAO.Instance.GetQuestionPapersByPaperId(pid);
        TlQuestionPaper? IPaperRepository.GetQuestionPaper(int id) => QuestionPaperDAO.Instance.GetQuestionPaper(id);
        bool IPaperRepository.AddQuestionPaper(TlQuestionPaper questionPaper) => QuestionPaperDAO.Instance.AddQuestionPaper(questionPaper);
        bool IPaperRepository.UpdateQuestionPaper(TlQuestionPaper questionPaper) => QuestionPaperDAO.Instance.UpdateQuestionPaper(questionPaper);
        bool IPaperRepository.DeleteQuestionPaper(int id) => QuestionPaperDAO.Instance.DeleteQuestionPaper(id);
        // Submit Paper
        List<TlSubmitpaper> IPaperRepository.GetSubmitPapers() => SubmitPaperDAO.Instance.GetSubmitPapers();
        List<TlSubmitpaper> IPaperRepository.GetSubmitPapers(int offset, int limit, int pid, string search) => SubmitPaperDAO.Instance.GetSubmitPapers(offset,limit,pid,search);
        TlSubmitpaper? IPaperRepository.GetSubmitPaper(int id) => SubmitPaperDAO.Instance.GetSubmitPaper(id);
        TlSubmitpaper? IPaperRepository.GetSubmitPaperByStudentId(int stdid) => SubmitPaperDAO.Instance.GetSubmitPaperByStudentId(stdid);
        TlSubmitpaper? IPaperRepository.GetSubmitPaperByStudentUsername(string username, int pid) => SubmitPaperDAO.Instance.GetSubmitPaperByStudentUsername(username, pid);
        TlSubmitpaper? IPaperRepository.AddSubmitPaper(TlSubmitpaper submitPaper) => SubmitPaperDAO.Instance.AddSubmitPaper(submitPaper);
        bool IPaperRepository.UpdateSubmitPaper(TlSubmitpaper submitPaper) => SubmitPaperDAO.Instance.UpdateSubmitPaper(submitPaper);
        bool IPaperRepository.DeleteSubmitPaper(int id) => SubmitPaperDAO.Instance.DeleteSubmitPaper(id);
        bool IPaperRepository.DeleteSubmitPaperByPaperId(int paperId) => SubmitPaperDAO.Instance.DeleteSubmitPaperByPaperId(paperId);
        // Submit Paper Detail
        List<TlSubmitpaperDetail> IPaperRepository.GetSubmitPaperDetails(int submitPaperId) => SubmitPaperDetailDAO.Instance.GetSubmitPaperDetails(submitPaperId);
        bool IPaperRepository.AddSubmitPaperDetail(TlSubmitpaperDetail submitPaperDetail) => SubmitPaperDetailDAO.Instance.AddSubmitPaperDetail(submitPaperDetail);
        bool IPaperRepository.UpdateSubmitPaperDetail(TlSubmitpaperDetail submitPaperDetail) => SubmitPaperDetailDAO.Instance.UpdateSubmitPaperDetail(submitPaperDetail);
        bool IPaperRepository.DeleteSubmitPaperDetail(int submitPaperId, int questionId, int answerId) => SubmitPaperDetailDAO.Instance.DeleteSubmitPaperDetail(submitPaperId, questionId, answerId);

        int IPaperRepository.CountAll() => PaperDAO.Instance.CountAll();

        List<TlPaper> IPaperRepository.GetPapersByCourseId(int idCourseSelected, string SearchValue) => PaperDAO.Instance.GetPapersByCourseId(idCourseSelected, SearchValue);

        TlSubmitpaper? IPaperRepository.GetSubmitPaperByStudent(int id, int paperid) => SubmitPaperDAO.Instance.GetSubmitPaperByStudent(id, paperid);

        List<TlSubmitpaperDetail> IPaperRepository.GetSubmitPaperDetails(int userId, int PaperId) => SubmitPaperDetailDAO.Instance.GetSubmitPaperDetails(userId, PaperId);
    }
}
