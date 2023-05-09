using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Question
{
    public class CourseDAO
    {
        private static CourseDAO? instance = null;
        private static readonly object padlock = new object();

        public static CourseDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CourseDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TlCourse> GetCourses()
        {
            List<TlCourse> courses = new List<TlCourse>();
            try
            {
                using (var db = new TestLabContext())
                {
                    courses = db.TlCourses.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courses;
        }

        public List<TlCourse> GetCourses(int offset = 0, int limit = 10, string search = "")
        {
            List<TlCourse> courses = new List<TlCourse>();
            try
            {
                using (var db = new TestLabContext())
                {
                    if (search == "")
                    {
                        courses = db.TlCourses.Skip(offset).Take(limit).ToList();
                    }
                    else
                    {
                        courses = db.TlCourses.Where(c => c.CourseName.Contains(search)).Skip(offset).Take(limit).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courses;
        }

        public List<TlCourse> GetCoursesByChapterId(int chapter_id)
        {
            List<TlCourse> courses = new List<TlCourse>();
            try
            {
                using (var db = new TestLabContext())
                {
                    courses = db.TlCourses.Where(c => c.TlChapters.Any(ch => ch.Id == chapter_id)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courses;
        }

        public TlCourse? GetCourseById(int id)
        {
            TlCourse? course = new TlCourse();
            try
            {
                using (var db = new TestLabContext())
                {
                    course = db.TlCourses.Where(c => c.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return course;
        }

        public TlCourse? GetCourseByName(string name)
        {
            TlCourse? course = new TlCourse();
            try
            {
                using (var db = new TestLabContext())
                {
                    course = db.TlCourses.Where(c => c.CourseName.Contains(name)).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return course;
        }

        public bool AddCourse(TlCourse course)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    db.TlCourses.Add(course);
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

        public bool UpdateCourse(TlCourse course)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    var courseToUpdate = db.TlCourses.Where(c => c.Id == course.Id).FirstOrDefault();
                    if (courseToUpdate != null)
                    {
                        courseToUpdate.CourseName = course.CourseName;
                        courseToUpdate.UpdateAt = DateTime.Now;
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

        public bool DeleteCourse(int id)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    var courseToDelete = db.TlCourses.Where(c => c.Id == id).FirstOrDefault();
                    if (courseToDelete != null)
                    {
                        db.TlCourses.Remove(courseToDelete);
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

        public int CountAll()
        {
            int count = 0;
            try
            {
                using (var db = new TestLabContext())
                {
                    count = db.TlCourses.Count();
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
