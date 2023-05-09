using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Paper
{
    public class SubmitPaperDetailDAO
    {
        private static SubmitPaperDetailDAO? instance;
        private static readonly object padlock = new object();

        public static SubmitPaperDetailDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SubmitPaperDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TlSubmitpaperDetail> GetSubmitPaperDetails(int submitPaperId)
        {
            List<TlSubmitpaperDetail> submitPaperDetails = new List<TlSubmitpaperDetail>();
            try
            {
                using (var db = new TestLabContext())
                {
                    submitPaperDetails = db.TlSubmitpaperDetails.Where(spd => spd.SubmitpaperId == submitPaperId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return submitPaperDetails;
        }

        public bool AddSubmitPaperDetail(TlSubmitpaperDetail submitPaperDetail)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    var spd = db.TlSubmitpaperDetails.Where(s => s.SubmitpaperId == submitPaperDetail.SubmitpaperId && s.QuestionId == submitPaperDetail.QuestionId && s.AnswerId == submitPaperDetail.AnswerId).FirstOrDefault();
                    if (spd == null)
                    {
                        db.TlSubmitpaperDetails.Add(submitPaperDetail);
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

        public bool UpdateSubmitPaperDetail(TlSubmitpaperDetail submitPaperDetail)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    var submitPaperDetailToUpdate = db.TlSubmitpaperDetails.Where(spd => spd.SubmitpaperId == submitPaperDetail.SubmitpaperId && spd.QuestionId == submitPaperDetail.QuestionId).FirstOrDefault();
                    if (submitPaperDetailToUpdate != null)
                    {
                        submitPaperDetailToUpdate.AnswerId = submitPaperDetail.AnswerId;
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

        public bool DeleteSubmitPaperDetail(int submitPaperId, int questionId, int answerId)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    var submitPaperDetailToDelete = db.TlSubmitpaperDetails.Where(spd => spd.SubmitpaperId == submitPaperId && spd.QuestionId == questionId && spd.AnswerId == answerId).FirstOrDefault();
                    if (submitPaperDetailToDelete != null)
                    {
                        db.TlSubmitpaperDetails.Remove(submitPaperDetailToDelete);
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

        public List<TlSubmitpaperDetail> GetSubmitPaperDetails(int userId, int paperId)
        {
            TlSubmitpaper? submitPaper = null;
            List<TlSubmitpaperDetail> submitPaperDetails = new List<TlSubmitpaperDetail>();
            try
            {
                using (var db = new TestLabContext())
                {
                    submitPaper = db.TlSubmitpapers.Where(sp => sp.StudentId == userId && sp.PaperId == paperId).FirstOrDefault();
                    if (submitPaper != null)
                    {
                        submitPaperDetails = db.TlSubmitpaperDetails.Where(spd => spd.SubmitpaperId == submitPaper.Id).ToList();
                    }
                    return submitPaperDetails;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
