using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Paper
{
    public class SubmitPaperDAO
    {
        private static SubmitPaperDAO? instance = null;
        private static readonly object padlock = new object();

        public static SubmitPaperDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SubmitPaperDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TlSubmitpaper> GetSubmitPapers()
        {
            List<TlSubmitpaper> submitPapers = new List<TlSubmitpaper>();
            try
            {
                using (var db = new TestLabContext())
                {
                    submitPapers = db.TlSubmitpapers.Include(sp => sp.Student).Include(sp => sp.Paper).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return submitPapers;
        }

        public List<TlSubmitpaper> GetSubmitPapers(int offset = 0, int limit = 10, int stdid = 0, int pid = 0)
        {
            List<TlSubmitpaper> submitPapers = new List<TlSubmitpaper>();
            try
            {
                using (var db = new TestLabContext())
                {
                    if (stdid == 0 && pid == 0)
                    {
                        submitPapers = db.TlSubmitpapers.Skip(offset).Take(limit).ToList();
                    }
                    else if (stdid == 0 && pid != 0)
                    {
                        submitPapers = db.TlSubmitpapers.Where(sp => sp.PaperId == pid).Skip(offset).Take(limit).ToList();
                    }
                    else if (stdid != 0 && pid == 0)
                    {
                        submitPapers = db.TlSubmitpapers.Where(sp => sp.StudentId == stdid).Skip(offset).Take(limit).ToList();
                    }
                    else
                    {
                        submitPapers = db.TlSubmitpapers.Where(sp => sp.StudentId == stdid && sp.PaperId == pid).Skip(offset).Take(limit).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return submitPapers;
        }

        public TlSubmitpaper? GetSubmitPaper(int id)
        {
            TlSubmitpaper? submitPaper = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    submitPaper = db.TlSubmitpapers.Where(sp => sp.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return submitPaper;
        }

        public TlSubmitpaper? GetSubmitPaperByStudentId(int stdid)
        {
            TlSubmitpaper? submitPaper = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    submitPaper = db.TlSubmitpapers.Where(sp => sp.StudentId == stdid).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return submitPaper;
        }

        public TlSubmitpaper? AddSubmitPaper(TlSubmitpaper submitPaper)
        {
            try
            {
                using (var db = new TestLabContext())
                {
                    db.TlSubmitpapers.Add(submitPaper);
                    db.SaveChanges();
                    return submitPaper;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateSubmitPaper(TlSubmitpaper submitPaper)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlSubmitpaper? submitPaperToUpdate = db.TlSubmitpapers.Where(sp => sp.Id == submitPaper.Id).FirstOrDefault();
                    if (submitPaperToUpdate != null)
                    {
                        submitPaperToUpdate.StudentId = submitPaper.StudentId;
                        submitPaperToUpdate.PaperId = submitPaper.PaperId;
                        submitPaperToUpdate.Mark = submitPaper.Mark;
                        submitPaperToUpdate.UpdateAt = DateTime.Now;
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Submit paper not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool DeleteSubmitPaper(int id)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlSubmitpaper? submitPaperToDelete = db.TlSubmitpapers.Where(sp => sp.Id == id).FirstOrDefault();
                    if (submitPaperToDelete != null)
                    {
                        db.TlSubmitpapers.Remove(submitPaperToDelete);
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Submit paper not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool DeleteSubmitPaperByPaperId(int paperId)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    List<TlSubmitpaper> submitPapersToDelete = db.TlSubmitpapers.Where(sp => sp.PaperId == paperId).ToList();
                    if (submitPapersToDelete.Count > 0)
                    {
                        db.TlSubmitpapers.RemoveRange(submitPapersToDelete);
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Submit paper not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public TlSubmitpaper? GetSubmitPaperByStudentUsername(string username, int pid)
        {
            TlSubmitpaper? submitPaper = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    submitPaper = db.TlSubmitpapers.Include(sp => sp.Student).Where(sp => sp.Student.Username == username && sp.PaperId == pid).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return submitPaper;
        }

        public TlSubmitpaper? GetSubmitPaperByStudent(int id, int paperid)
        {
            TlSubmitpaper? submitPaper = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    submitPaper = db.TlSubmitpapers.Where(sp => sp.StudentId == id && sp.PaperId == paperid).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return submitPaper;
        }

        public List<TlSubmitpaper> GetSubmitPapers(int offset, int limit, int pid, string search)
        {
            List<TlSubmitpaper> submitPapers = new List<TlSubmitpaper>();
            try
            {
                using (var db = new TestLabContext())
                {
                    if (pid == 0)
                    {
                        submitPapers = db.TlSubmitpapers.Include(sp => sp.Student).Include(sp => sp.Paper).Where(sp => sp.Student.Username.Contains(search)).Skip(offset).Take(limit).ToList();
                    }
                    else
                    {
                        submitPapers = db.TlSubmitpapers.Include(sp => sp.Student).Include(sp => sp.Paper).Where(sp => sp.Student.Username.Contains(search) && sp.PaperId == pid).Skip(offset).Take(limit).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return submitPapers;
        }
    }
}
