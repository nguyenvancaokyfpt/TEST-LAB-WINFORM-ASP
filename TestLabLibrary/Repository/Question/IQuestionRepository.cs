using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.Repository
{
    public interface IQuestionRepository
    {
        // Question
        List<TlQuestion> GetQuestions();
        List<TlQuestion> GetQuestions(int offset = 0, int limit = 10, int course_id = 0, int chapter_id = 0);
        List<TlQuestion> GetQuestions(int offset = 0, int limit = 10, int course_id = 0, int chapter_id = 0, string searchValue = "");
        TlQuestion? GetQuestion(int id);
        TlQuestion? GetQuestion(string question_text);
        int AddQuestion(TlQuestion question);
        bool UpdateQuestion(TlQuestion question);
        bool DeleteQuestion(int id);
        int CountAll();
        // Course
        List<TlCourse> GetCourses();
        List<TlCourse> GetCourses(int offset = 0, int limit = 10, string search = "");
        List<TlCourse> GetCoursesByChapterId(int chapter_id);
        TlCourse? GetCourseById(int id);
        TlCourse? GetCourseByName(string name);
        bool AddCourse(TlCourse course);
        bool UpdateCourse(TlCourse course);
        bool DeleteCourse(int id);
        int CountAllCourse();
        // Chapter
        List<TlChapter> GetChapters();
        List<TlChapter> GetChapters(int offset = 0, int limit = 10, int course_id = 0, string search = "");
        TlChapter? GetChapter(int id);
        bool AddChapter(TlChapter chapter);
        bool UpdateChapter(TlChapter chapter);
        bool DeleteChapter(int id);
        int CountAllChapter();
        // Answer
        List<TlAnswer> GetAnswers(int qid);
        TlAnswer? GetAnswer(int id);
        bool AddAnswer(TlAnswer answer);
        bool UpdateAnswer(TlAnswer answer);
        bool DeleteAnswer(int id);
        bool DeleteAnswerByQuestionId(int id);
        List<TlQuestion> GetQuestionsByPaperId(int idPaperSelected);
        bool DeleteQuestionPaper(int id, int IdPaperSelected);
        bool DeleteAllQuestionByPaperId(int idPaperSelected);
        bool AddQuestionToPaper(int id, int idPaperSelected);
        List<TlSubmitpaperDetail> GetSubmitPaperDetails(int id);
        object GetQuestionsOfPaper(int id);
    }
}
