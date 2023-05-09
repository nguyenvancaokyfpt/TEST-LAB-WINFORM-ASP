using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLabEntity.AutoDB;

namespace TestLabLibrary.DataAccess.Student
{
    public class StudentDAO
    {
        private static StudentDAO? instance = null;
        private static readonly object padlock = new object();

        public static StudentDAO Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new StudentDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TlStudent> GetStudents()
        {
            List<TlStudent> students = new List<TlStudent>();
            try
            {
                using (var db = new TestLabContext())
                {
                    students = db.TlStudents.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return students;
        }

        public List<TlStudent> GetStudents(int offset = 0, int limit = 10, string search = "")
        {
            List<TlStudent> students = new List<TlStudent>();
            try
            {
                using (var db = new TestLabContext())
                {
                    if (search == "")
                    {
                        students = db.TlStudents.Skip(offset).Take(limit).ToList();
                    }
                    else
                    {
                        students = db.TlStudents.Where(s => s.Username.Contains(search)).Skip(offset).Take(limit).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return students;
        }

        public TlStudent? GetStudentById(int id)
        {
            TlStudent? student = new TlStudent();
            try
            {
                using (var db = new TestLabContext())
                {
                    student = db.TlStudents.Where(s => s.Id == id).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }

        public TlStudent? GetStudentByUsername(string username)
        {
            TlStudent? student = new TlStudent();
            try
            {
                using (var db = new TestLabContext())
                {
                    student = db.TlStudents.Where(s => s.Username == username).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }

        public bool AddStudent(TlStudent student)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    db.TlStudents.Add(student);
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

        public bool UpdateStudent(TlStudent student)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlStudent? studentToUpdate = db.TlStudents.Where(s => s.Id == student.Id).FirstOrDefault();
                    if (studentToUpdate != null) {
                        studentToUpdate.Username = student.Username;
                        studentToUpdate.Password = student.Password;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool DeleteStudent(int id)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlStudent? studentToDelete = db.TlStudents.Where(s => s.Id == id).FirstOrDefault();
                    if (studentToDelete != null)
                    {
                        db.TlStudents.Remove(studentToDelete);
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

        public bool Login(string username, string password)
        {
            bool result = false;
            try
            {
                using (var db = new TestLabContext())
                {
                    TlStudent? student = db.TlStudents.Where(s => s.Username == username && s.Password == password).FirstOrDefault();
                    if (student != null)
                    {
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
            int result = 0;
            try
            {
                using (var db = new TestLabContext())
                {
                    result = db.TlStudents.Count();
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
