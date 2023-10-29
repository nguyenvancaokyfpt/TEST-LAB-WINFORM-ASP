using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;
using TestLabLibrary.DataAccess.Question;

namespace TestLabLibrary.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        List<TlQuestion> IQuestionRepository.GetQuestions() => QuestionDAO.Instance.GetQuestions();
        List<TlQuestion> IQuestionRepository.GetQuestions(int offset, int limit, int course_id, int chapter_id) => QuestionDAO.Instance.GetQuestions(offset, limit, course_id, chapter_id);
        List<TlQuestion> IQuestionRepository.GetQuestions(int offset, int limit, int course_id, int chapter_id, string searchValue) => QuestionDAO.Instance.GetQuestions(offset, limit, course_id, chapter_id, searchValue);
        TlQuestion? IQuestionRepository.GetQuestion(int id) => QuestionDAO.Instance.GetQuestion(id);
        TlQuestion? IQuestionRepository.GetQuestion(string question_text) => QuestionDAO.Instance.GetQuestion(question_text);
        int IQuestionRepository.AddQuestion(TlQuestion question) => QuestionDAO.Instance.AddQuestion(question);
        bool IQuestionRepository.UpdateQuestion(TlQuestion question) => QuestionDAO.Instance.UpdateQuestion(question);
        bool IQuestionRepository.DeleteQuestion(int id) => QuestionDAO.Instance.DeleteQuestion(id);
        // Course
        List<TlCourse> IQuestionRepository.GetCourses() => CourseDAO.Instance.GetCourses();
        List<TlCourse> IQuestionRepository.GetCourses(int offset, int limit, string search) => CourseDAO.Instance.GetCourses(offset, limit, search);
        List<TlCourse> IQuestionRepository.GetCoursesByChapterId(int chapter_id) => CourseDAO.Instance.GetCoursesByChapterId(chapter_id);
        TlCourse? IQuestionRepository.GetCourseById(int id) => CourseDAO.Instance.GetCourseById(id);
        TlCourse? IQuestionRepository.GetCourseByName(string name) => CourseDAO.Instance.GetCourseByName(name);
        bool IQuestionRepository.AddCourse(TlCourse course) => CourseDAO.Instance.AddCourse(course);
        bool IQuestionRepository.UpdateCourse(TlCourse course) => CourseDAO.Instance.UpdateCourse(course);
        bool IQuestionRepository.DeleteCourse(int id) => CourseDAO.Instance.DeleteCourse(id);
        // Chapter
        List<TlChapter> IQuestionRepository.GetChapters() => ChapterDAO.Instance.GetChapters();
        List<TlChapter> IQuestionRepository.GetChapters(int offset, int limit, int course_id, string search) => ChapterDAO.Instance.GetChapters(offset, limit, course_id, search);
        TlChapter? IQuestionRepository.GetChapter(int id) => ChapterDAO.Instance.GetChapter(id);
        bool IQuestionRepository.AddChapter(TlChapter chapter) => ChapterDAO.Instance.AddChapter(chapter);
        bool IQuestionRepository.UpdateChapter(TlChapter chapter) => ChapterDAO.Instance.UpdateChapter(chapter);
        bool IQuestionRepository.DeleteChapter(int id) => ChapterDAO.Instance.DeleteChapter(id);
        // Answer
        List<TlAnswer> IQuestionRepository.GetAnswers(int qid) => AnswerDAO.Instance.GetAnswers(qid);
        TlAnswer? IQuestionRepository.GetAnswer(int id) => AnswerDAO.Instance.GetAnswer(id);
        bool IQuestionRepository.AddAnswer(TlAnswer answer) => AnswerDAO.Instance.AddAnswer(answer);
        bool IQuestionRepository.UpdateAnswer(TlAnswer answer) => AnswerDAO.Instance.UpdateAnswer(answer);
        bool IQuestionRepository.DeleteAnswer(int id) => AnswerDAO.Instance.DeleteAnswer(id);

        int IQuestionRepository.CountAll() => QuestionDAO.Instance.CountAll();

        int IQuestionRepository.CountAllCourse() => CourseDAO.Instance.CountAll();

        int IQuestionRepository.CountAllChapter() => ChapterDAO.Instance.CountAll();

        bool IQuestionRepository.DeleteAnswerByQuestionId(int id) => AnswerDAO.Instance.DeleteAnswerByQuestionId(id);

        List<TlQuestion> IQuestionRepository.GetQuestionsByPaperId(int idPaperSelected) => QuestionDAO.Instance.GetQuestionsByPaperId(idPaperSelected);

        bool IQuestionRepository.DeleteQuestionPaper(int id, int IdPaperSelected) => QuestionDAO.Instance.DeleteQuestionPaper(id, IdPaperSelected);

        bool IQuestionRepository.DeleteAllQuestionByPaperId(int idPaperSelected) => QuestionDAO.Instance.DeleteAllQuestionByPaperId(idPaperSelected);

        bool IQuestionRepository.AddQuestionToPaper(int id, int idPaperSelected) => QuestionDAO.Instance.AddQuestionToPaper(id, idPaperSelected);

        List<TlSubmitpaperDetail> IQuestionRepository.GetSubmitPaperDetails(int id) => QuestionDAO.Instance.GetSubmitPaperDetails(id);

        object IQuestionRepository.GetQuestionsOfPaper(int id)
        {
            throw new NotImplementedException();
        }
    }
}
