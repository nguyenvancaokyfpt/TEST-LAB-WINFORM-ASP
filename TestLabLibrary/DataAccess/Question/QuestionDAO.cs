using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Question
{
    public class QuestionDAO
    {
        private static QuestionDAO? instance = null;
        private static readonly object padlock = new object();

        public static QuestionDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new QuestionDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TlQuestion> GetQuestions()
        {
            List<TlQuestion> questions = new List<TlQuestion>();
            try
            {
                using (var db = new TestLabContext())
                {
                    questions = db.TlQuestions.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return questions;
        }

        public List<TlQuestion> GetQuestions(int offset = 0, int limit = 10, int course_id = 0, int chapter_id = 0)
        {
            List<TlQuestion> questions = new List<TlQuestion>();
            try
            {
                using (var db = new TestLabContext())
                {
                    if (course_id == 0 && chapter_id == 0)
                    {
                        questions = db.TlQuestions.Skip(offset).Take(limit).ToList();
                    }
                    else if (course_id == 0 && chapter_id != 0)
                    {
                        questions = db.TlQuestions.Where(q => q.ChapterId == chapter_id).Skip(offset).Take(limit).ToList();
                    }
                    else if (course_id != 0 && chapter_id == 0)
                    {
                        questions = db.TlQuestions.Where(q => q.Chapter.CourseId == course_id).Skip(offset).Take(limit).ToList();
                    }
                    else
                    {
                        questions = db.TlQuestions.Where(q => q.ChapterId == chapter_id && q.Chapter.CourseId == course_id).Skip(offset).Take(limit).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return questions;
        }

        public List<TlQuestion> GetQuestions(int offset = 0, int limit = 10, int course_id = 0, int chapter_id = 0, string search = "")
        {
            List<TlQuestion> questions = new List<TlQuestion>();
            try
            {
                using (var db = new TestLabContext())
                {
                    questions = db.TlQuestions.Where(q => q.ChapterId == chapter_id && q.CourseId == course_id && q.QuestionText.Contains(search)).Skip(offset).Take(limit).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return questions;
        }

        public TlQuestion? GetQuestion(int id)
        {
            TlQuestion? question = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    question = db.TlQuestions.Where(q => q.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return question;
        }

        public TlQuestion? GetQuestion(string question_text)
        {
            TlQuestion? question = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    question = db.TlQuestions.Where(q => q.QuestionText.Contains(question_text)).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return question;
        }

        public int AddQuestion(TlQuestion question)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    db.TlQuestions.Add(question);
                    db.SaveChanges();
                    return question.Id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

        public bool UpdateQuestion(TlQuestion question)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlQuestion? questionToUpdate = db.TlQuestions.Where(q => q.Id == question.Id).FirstOrDefault();
                    if (questionToUpdate != null)
                    {
                        questionToUpdate.ChapterId = question.ChapterId;
                        questionToUpdate.QuestionText = question.QuestionText;
                        questionToUpdate.QuestionImage = question.QuestionImage;
                        questionToUpdate.CourseId = question.CourseId;
                        questionToUpdate.UpdateAt = DateTime.Now;
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Question not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool DeleteQuestion(int id)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlQuestion? questionToDelete = db.TlQuestions.Where(q => q.Id == id).FirstOrDefault();
                    if (questionToDelete != null)
                    {
                        db.TlQuestions.Remove(questionToDelete);
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Question not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public int CountAll()
        {
            int count = 0;
            try
            {
                using (var db = new TestLabContext())
                {
                    count = db.TlQuestions.Count();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return count;
        }

        public List<TlQuestion> GetQuestionsByPaperId(int idPaperSelected)
        {
            List<TlQuestionPaper> questionPapers = new List<TlQuestionPaper>();
            List<TlQuestion> questions = new List<TlQuestion>();
            try
            {
                using (var db = new TestLabContext())
                {
                    questionPapers = db.TlQuestionPapers.Where(qp => qp.PaperId == idPaperSelected).ToList();
                    foreach (var item in questionPapers)
                    {
                        var q = db.TlQuestions.Include(x => x.TlAnswers).Where(q => q.Id == item.QuestionId).FirstOrDefault();
                        if (q != null)
                        {
                            questions.Add(q);
                        }
                    }
                    return questions;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteQuestionPaper(int id, int IdPaperSelected)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlQuestionPaper? questionToDelete = db.TlQuestionPapers.Where(q => q.QuestionId == id && q.PaperId == IdPaperSelected).FirstOrDefault();
                    if (questionToDelete != null)
                    {
                        db.TlQuestionPapers.Remove(questionToDelete);
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Question not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool DeleteAllQuestionByPaperId(int idPaperSelected)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    List<TlQuestionPaper> questionToDelete = db.TlQuestionPapers.Where(q => q.PaperId == idPaperSelected).ToList();
                    if (questionToDelete != null)
                    {
                        db.TlQuestionPapers.RemoveRange(questionToDelete);
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Question not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool AddQuestionToPaper(int id, int idPaperSelected)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlQuestionPaper questionPaper = new TlQuestionPaper();
                    questionPaper.PaperId = idPaperSelected;
                    questionPaper.QuestionId = id;
                    questionPaper.Mark = 1;
                    db.TlQuestionPapers.Add(questionPaper);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<TlSubmitpaperDetail> GetSubmitPaperDetails(int id)
        {
            List<TlSubmitpaperDetail> submitpaperDetails = new List<TlSubmitpaperDetail>();
            try {
                using (var db = new TestLabContext())
                {
                    submitpaperDetails = db.TlSubmitpaperDetails.Where(q => q.SubmitpaperId == id).ToList();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return submitpaperDetails;
        }
    }
}
