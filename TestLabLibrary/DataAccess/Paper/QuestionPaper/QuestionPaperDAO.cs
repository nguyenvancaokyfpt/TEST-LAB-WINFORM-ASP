using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Paper
{
    public class QuestionPaperDAO
    {
        private static QuestionPaperDAO? instance;
        private static readonly object padlock = new object();

        public static QuestionPaperDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new QuestionPaperDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TlQuestionPaper> GetQuestionPapers()
        {
            List<TlQuestionPaper> questionPapers = new List<TlQuestionPaper>();
            try
            {
                using (var db = new TestLabContext())
                {
                    questionPapers = db.TlQuestionPapers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return questionPapers;
        }

        public List<TlQuestionPaper> GetQuestionPapers(int offset = 0, int limit = 10, int qid = 0, int pid = 0)
        {
            List<TlQuestionPaper> questionPapers = new List<TlQuestionPaper>();
            try
            {
                using (var db = new TestLabContext())
                {
                    if (qid == 0 && pid == 0)
                    {
                        questionPapers = db.TlQuestionPapers.Skip(offset).Take(limit).ToList();
                    }
                    else if (qid == 0 && pid != 0)
                    {
                        questionPapers = db.TlQuestionPapers.Where(qp => qp.PaperId == pid).Skip(offset).Take(limit).ToList();
                    }
                    else if (qid != 0 && pid == 0)
                    {
                        questionPapers = db.TlQuestionPapers.Where(qp => qp.QuestionId == qid).Skip(offset).Take(limit).ToList();
                    }
                    else
                    {
                        questionPapers = db.TlQuestionPapers.Where(qp => qp.QuestionId == qid && qp.PaperId == pid).Skip(offset).Take(limit).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return questionPapers;
        }

        public TlQuestionPaper? GetQuestionPapersByPaperId(int pid)
        {
            TlQuestionPaper? questionPaper = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    questionPaper = db.TlQuestionPapers.Where(qp => qp.PaperId == pid).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return questionPaper;
        }

        public TlQuestionPaper? GetQuestionPaper(int id)
        {
            TlQuestionPaper? questionPaper = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    questionPaper = db.TlQuestionPapers.Where(q => q.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return questionPaper;
        }

        public bool AddQuestionPaper(TlQuestionPaper questionPaper)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
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

        public bool UpdateQuestionPaper(TlQuestionPaper questionPaper)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlQuestionPaper? qp = db.TlQuestionPapers.Where(q => q.Id == questionPaper.Id).FirstOrDefault();
                    if (qp != null)
                    {
                        qp.QuestionId = questionPaper.QuestionId;
                        qp.PaperId = questionPaper.PaperId;
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("QuestionPaper not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool DeleteQuestionPaper(int id)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    var questionPaper = db.TlQuestionPapers.Where(q => q.Id == id).FirstOrDefault();
                    if (questionPaper != null)
                    {
                        db.TlQuestionPapers.Remove(questionPaper);
                        db.SaveChanges();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }


    }
}
