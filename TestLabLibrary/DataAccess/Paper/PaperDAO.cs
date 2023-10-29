using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Paper
{
    public class PaperDAO
    {
        private static PaperDAO? instance;
        private static readonly object padlock = new object();

        public static PaperDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PaperDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TlPaper> GetPapers()
        {
            List<TlPaper> papers = new List<TlPaper>();
            try
            {
                using (var db = new TestLabContext())
                {
                    papers = db.TlPapers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return papers;
        }

        public List<TlPaper> GetPapers(int offset = 0, int limit = 10, string search = "")
        {
            List<TlPaper> papers = new List<TlPaper>();
            try
            {
                using (var db = new TestLabContext())
                {
                    if (search == "")
                    {
                        papers = db.TlPapers.Include(p => p.Course).Skip(offset).Take(limit).ToList();
                    }
                    else
                    {
                        papers = db.TlPapers.Include(p => p.Course).Where(p => p.PaperName.Contains(search) && p.PaperCode.Contains(search)).Skip(offset).Take(limit).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return papers;
        }

        public TlPaper? GetPaper(int id)
        {
            TlPaper? paper = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    paper = db.TlPapers.Where(p => p.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return paper;
        }

        public TlPaper? GetPaper(string code)
        {
            TlPaper? paper = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    paper = db.TlPapers.Where(p => p.PaperCode == code).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return paper;
        }

        public int AddPaper(TlPaper paper)
        {
            try
            {
                using (var db = new TestLabContext())
                {
                    db.TlPapers.Add(paper);
                    db.SaveChanges();
                    return paper.Id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

        public bool UpdatePaper(TlPaper paper)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlPaper? paperToUpdate = db.TlPapers.Where(p => p.Id == paper.Id).FirstOrDefault();
                    if (paperToUpdate != null)
                    {
                        paperToUpdate.PaperCode = paper.PaperCode;
                        paperToUpdate.PaperName = paper.PaperName;
                        paperToUpdate.QuestionNum = paper.QuestionNum;
                        paperToUpdate.StartTime = paper.StartTime;
                        paperToUpdate.EndTime = paper.EndTime;
                        paperToUpdate.Duration = paper.Duration;
                        paperToUpdate.UpdateAt = DateTime.Now;
                        paperToUpdate.IsOpen = paper.IsOpen;
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Paper not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool DeletePaper(int id)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlPaper? paperToDelete = db.TlPapers.Where(p => p.Id == id).FirstOrDefault();
                    if (paperToDelete != null)
                    {
                        // Delete all questions in this paper
                        List<TlQuestionPaper> questionPapers = db.TlQuestionPapers.Where(qp => qp.PaperId == id).ToList();
                        foreach (TlQuestionPaper questionPaper in questionPapers)
                        {
                            db.TlQuestionPapers.Remove(questionPaper);
                        }
                        db.TlPapers.Remove(paperToDelete);
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Paper not found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool DeletePaper(string code)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlPaper? paperToDelete = db.TlPapers.Where(p => p.PaperCode == code).FirstOrDefault();
                    if (paperToDelete != null)
                    {
                        db.TlPapers.Remove(paperToDelete);
                        db.SaveChanges();
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Paper not found");
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
                    count = db.TlPapers.Count();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return count;
        }

        public List<TlPaper> GetPapersByCourseId(int idCourseSelected, string SearchValue)
        {
            List<TlPaper> papers = new List<TlPaper>();
            try
            {
                using (var db = new TestLabContext())
                {
                    if (SearchValue == "")
                    {
                        papers = db.TlPapers.Where(p => p.CourseId == idCourseSelected).ToList();
                    }
                    else
                    {
                        papers = db.TlPapers.Where(p => p.CourseId == idCourseSelected && p.PaperName.Contains(SearchValue) && p.PaperCode.Contains(SearchValue)).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return papers;
        }
    }
}
