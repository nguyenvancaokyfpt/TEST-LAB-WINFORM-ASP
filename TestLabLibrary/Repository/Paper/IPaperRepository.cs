using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.Repository
{
    public interface IPaperRepository
    {
        // Paper
        List<TlPaper> GetPapers();
        List<TlPaper> GetPapers(int offset = 0, int limit = 10, string search = "");
        TlPaper? GetPaper(int id);
        TlPaper? GetPaper(string code);
        int AddPaper(TlPaper paper);
        bool UpdatePaper(TlPaper paper);
        bool DeletePaper(int id);
        bool DeletePaper(string code);
        int CountAll();
        // Paper Question
        List<TlQuestionPaper> GetQuestionPapers(int paper_id);
        List<TlQuestionPaper> GetQuestionPapers(int offset = 0, int limit = 10, int qid = 0, int pid = 0);
        TlQuestionPaper? GetQuestionPapersByPaperId(int pid);
        TlQuestionPaper? GetQuestionPaper(int id);
        bool AddQuestionPaper(TlQuestionPaper questionPaper);
        bool UpdateQuestionPaper(TlQuestionPaper questionPaper);
        bool DeleteQuestionPaper(int id);
        // Submit Paper
        List<TlSubmitpaper> GetSubmitPapers();
        List<TlSubmitpaper> GetSubmitPapers(int offset, int limit, int pid, string search);
        TlSubmitpaper? GetSubmitPaper(int id);
        TlSubmitpaper? GetSubmitPaperByStudentId(int stdid);
        TlSubmitpaper? GetSubmitPaperByStudentUsername(string username, int pid);
        TlSubmitpaper? AddSubmitPaper(TlSubmitpaper submitPaper);
        bool UpdateSubmitPaper(TlSubmitpaper submitPaper);
        bool DeleteSubmitPaper(int id);
        bool DeleteSubmitPaperByPaperId(int paperId);
        // Submit Paper Detail
        List<TlSubmitpaperDetail> GetSubmitPaperDetails(int submitPaperId);
        bool AddSubmitPaperDetail(TlSubmitpaperDetail submitPaperDetail);
        bool UpdateSubmitPaperDetail(TlSubmitpaperDetail submitPaperDetail);
        bool DeleteSubmitPaperDetail(int submitPaperId, int questionId, int answerId);
        List<TlPaper> GetPapersByCourseId(int idCourseSelected, string SearchValue);
        TlSubmitpaper? GetSubmitPaperByStudent(int id, int paperid);
        List<TlSubmitpaperDetail> GetSubmitPaperDetails(int userId, int PaperId);
    }
}
