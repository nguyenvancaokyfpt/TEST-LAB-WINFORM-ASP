using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Question
{
    public class ChapterDAO
    {
        private static ChapterDAO? instance = null;
        private static readonly object padlock = new object();

        public static ChapterDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ChapterDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TlChapter> GetChapters()
        {
            List<TlChapter> chapters = new List<TlChapter>();
            try
            {
                using (var db = new TestLabContext())
                {
                    chapters = db.TlChapters.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return chapters;
        }

        public List<TlChapter> GetChapters(int offset = 0, int limit = 10, int course_id = 0, string search = "")
        {
            List<TlChapter> chapters = new List<TlChapter>();
            try
            {
                using (var db = new TestLabContext())
                {
                    if (course_id == 0 && search == "")
                    {
                        chapters = db.TlChapters.Include(c => c.Course).Skip(offset).Take(limit).ToList();
                    }
                    else if (course_id == 0 && search != "")
                    {
                        chapters = db.TlChapters.Include(c=> c.Course).Where(c => c.ChapterName.Contains(search)).Skip(offset).Take(limit).ToList();
                    }
                    else if (course_id != 0 && search == "")
                    {
                        chapters = db.TlChapters.Include(c => c.Course).Where(c => c.CourseId == course_id).Skip(offset).Take(limit).ToList();
                    }
                    else
                    {
                        chapters = db.TlChapters.Include(c => c.Course).Where(c => c.CourseId == course_id && c.ChapterName.Contains(search)).Skip(offset).Take(limit).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return chapters;
        }

        public TlChapter? GetChapter(int id)
        {
            TlChapter? chapter = null;
            try
            {
                using (var db = new TestLabContext())
                {
                    chapter = db.TlChapters.Where(c => c.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return chapter;
        }

        public bool AddChapter(TlChapter chapter)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    db.TlChapters.Add(chapter);
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

        public bool UpdateChapter(TlChapter chapter)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlChapter? oldChapter = db.TlChapters.Where(c => c.Id == chapter.Id).FirstOrDefault();
                    if (oldChapter != null)
                    {
                        oldChapter.ChapterName = chapter.ChapterName;
                        oldChapter.CourseId = chapter.CourseId;
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

        public bool DeleteChapter(int id)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlChapter? chapter = db.TlChapters.Where(c => c.Id == id).FirstOrDefault();
                    if (chapter != null)
                    {
                        db.TlChapters.Remove(chapter);
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

        public int CountAll(){
            int count = 0;
            try
            {
                using (var db = new TestLabContext())
                {
                    count = db.TlChapters.Count();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return count;
        }

    }
}
