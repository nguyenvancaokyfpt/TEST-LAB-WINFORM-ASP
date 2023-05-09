using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Question
{
    public class AnswerDAO
    {
        private static AnswerDAO? instance = null;
        private static readonly object padlock = new object();

        public static AnswerDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new AnswerDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TlAnswer> GetAnswers(int qid)
        {
            List<TlAnswer> answers = new List<TlAnswer>();
            try
            {
                using (var db = new TestLabContext())
                {
                    answers = db.TlAnswers.Where(a => a.QuestionId == qid).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return answers;
        }

        public TlAnswer? GetAnswer(int id)
        {
            TlAnswer? answer = new TlAnswer();
            try
            {
                using (var db = new TestLabContext())
                {
                    answer = db.TlAnswers.Where(a => a.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return answer;
        }

        public bool AddAnswer(TlAnswer answer)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    db.TlAnswers.Add(answer);
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

        public bool UpdateAnswer(TlAnswer answer)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlAnswer? answerToUpdate = db.TlAnswers.Where(a => a.Id == answer.Id).FirstOrDefault();
                    if (answerToUpdate != null)
                    {
                        answerToUpdate.AnswerText = answer.AnswerText;
                        answerToUpdate.IsCorrect = answer.IsCorrect;
                        answerToUpdate.QuestionId = answer.QuestionId;
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

        public bool DeleteAnswer(int id)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlAnswer? answer = db.TlAnswers.Where(a => a.Id == id).FirstOrDefault();
                    if (answer != null)
                    {
                        db.TlAnswers.Remove(answer);
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

        public bool DeleteAnswerByQuestionId(int id)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    List<TlAnswer> answers = db.TlAnswers.Where(a => a.QuestionId == id).ToList();
                    if (answers != null)
                    {
                        db.TlAnswers.RemoveRange(answers);
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
