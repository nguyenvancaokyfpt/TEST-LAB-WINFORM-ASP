using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TracNghiemOnline.Common;
namespace TracNghiemOnline.Models
{
    public class AdminDA
    {
        User user = new User();
        trac_nghiem_onlineEntities db = new trac_nghiem_onlineEntities();

        public void UpdateLastLogin()
        {
            var update = (from x in db.admins where x.id_admin == user.ID select x).Single();
            update.last_login = DateTime.Now;
            db.SaveChanges();
        }
        public void UpdateLastSeen(string name,string url)
        {
            var update = (from x in db.admins where x.id_admin == user.ID select x).Single();
            update.last_seen = name;
            update.last_seen_url = url;
            db.SaveChanges();
        }
        public Dictionary<string, int> GetDashBoard()
        {
            var ListCount = new Dictionary<string, int>();
            int CountAdmin = db.admins.Count();
            ListCount.Add("CountAdmin", CountAdmin);
            int CountTeacher = db.teachers.Count();
            ListCount.Add("CountTeacher", CountTeacher);
            int CountStudent = db.students.Count();
            ListCount.Add("CountStudent", CountStudent);
            int CountGrade = db.grades.Count();
            ListCount.Add("CountGrade", CountGrade);
            int CountClass = db.classes.Count();
            ListCount.Add("CountClass", CountClass);
            int CountSpeciality = db.specialities.Count();
            ListCount.Add("CountSpeciality", CountSpeciality);
            int CountSubject = db.subjects.Count();
            ListCount.Add("CountSubject", CountSubject);
            int CountQuestion = db.questions.Count();
            ListCount.Add("CountQuestion", CountQuestion);
            int CountTest = db.tests.Count();
            ListCount.Add("CountTest", CountTest);
            return ListCount;
        }
        public List<admin> GetAdmins()
        {
            return db.admins.ToList();
        }
        public admin GetAdmin(int id)
        {
            admin admin = new admin();
            try
            {
                admin = db.admins.SingleOrDefault(x => x.id_admin == id);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
            return admin;
        }
        public bool AddAdmin(string name ,string username, string password, string gender, string email, string birthday)
        {
            var admin = new admin();
            admin.name = name;
            admin.username = username;
            admin.password = Common.Encryptor.MD5Hash(password);
            admin.gender = gender;
            admin.email = email;
            admin.id_permission = 1;
            admin.avatar = "avatar-default.jpg";
            admin.birthday = Convert.ToDateTime(birthday);
            try
            {
                db.admins.Add(admin);
                db.SaveChanges();
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool DeleteAdmin(int id)
        {
            try
            {
                var delete = (from x in db.admins where x.id_admin == id select x).Single();
                db.admins.Remove(delete);
                db.SaveChanges();
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool EditAdmin(int id_admin, string name, string username, string password, string gender, string email, string birthday)
        {
            try
            {
                var update = (from x in db.admins where x.id_admin == id_admin select x).Single();
                update.name = name;
                update.username = username;
                update.email = email;
                update.gender = gender;
                update.birthday = Convert.ToDateTime(birthday);
                if(password != null)
                    update.password = Common.Encryptor.MD5Hash(password);
                db.SaveChanges();
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public List<TeacherViewModel> GetTeachers()
        {
            List<TeacherViewModel> teachers = (from x in db.teachers join s in db.specialities on x.id_speciality equals s.id_speciality select new TeacherViewModel{ teacher = x, speciality = s}).ToList();
            return teachers;
        }
        public List<speciality> GetSpecialities()
        {
            return db.specialities.ToList();
        }
        public bool AddTeacher(string name, string username, string password, string gender, string email, string birthday, int id_speciality)
        {
            var teacher = new teacher();
            teacher.name = name;
            teacher.username = username;
            teacher.password = Common.Encryptor.MD5Hash(password);
            teacher.gender = gender;
            teacher.email = email;
            teacher.id_permission = 2;
            teacher.id_speciality = id_speciality;
            teacher.avatar = "avatar-default.jpg";
            teacher.birthday = Convert.ToDateTime(birthday);
            try
            {
                db.teachers.Add(teacher);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool DeleteTeacher(int id)
        {
            try
            {
                var delete = (from x in db.teachers where x.id_teacher == id select x).Single();
                db.teachers.Remove(delete);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public teacher GetTeacher(int id)
        {
            teacher teacher = new teacher();
            try
            {
                teacher = db.teachers.SingleOrDefault(x => x.id_teacher == id);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            return teacher;
        }
        public bool EditTeacher(int id_teacher, string name, string username, string password, string gender, string email, string birthday, int id_speciality)
        {
            try
            {
                var update = (from x in db.teachers where x.id_teacher == id_teacher select x).Single();
                update.name = name;
                update.username = username;
                update.email = email;
                update.gender = gender;
                update.id_speciality = id_speciality;
                update.birthday = Convert.ToDateTime(birthday);
                if (password != null)
                    update.password = Common.Encryptor.MD5Hash(password);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public List<@class> GetClasses()
        {
            return db.classes.ToList();
        }
        public List<StudentViewModel> GetStudents()
        {
            List<StudentViewModel> students = (from x in db.students
                                               join s in db.specialities on x.id_speciality equals s.id_speciality
                                               join c in db.classes on x.id_class equals c.id_class
                                               select new StudentViewModel { student = x, speciality = s, Class = c }).ToList();
            return students;
        }
        public bool AddStudent(string name, string username, string password, string gender, string email, string birthday, int id_speciality, int id_class)
        {
            var student = new student();
            student.name = name;
            student.username = username;
            student.password = Common.Encryptor.MD5Hash(password);
            student.gender = gender;
            student.email = email;
            student.id_permission = 3;
            student.id_speciality = id_speciality;
            student.id_class = id_class;
            student.avatar = "avatar-default.jpg";
            student.birthday = Convert.ToDateTime(birthday);
            try
            {
                db.students.Add(student);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool DeleteStudent(int id)
        {
            try
            {
                var delete = (from x in db.students where x.id_student == id select x).Single();
                db.students.Remove(delete);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public student GetStudent(int id)
        {
            student student = new student();
            try
            {
                student = db.students.SingleOrDefault(x => x.id_student == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return student;
        }
        public bool EditStudent(int id_student, string name, string username, string password, string gender, string email, string birthday, int id_speciality, int id_class)
        {
            try
            {
                var update = (from x in db.students where x.id_student == id_student select x).Single();
                update.name = name;
                update.username = username;
                update.email = email;
                update.gender = gender;
                update.id_speciality = id_speciality;
                update.id_class = id_class;
                update.birthday = Convert.ToDateTime(birthday);
                if (password != null)
                    update.password = Common.Encryptor.MD5Hash(password);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public List<grade> GetGrades()
        {
            return db.grades.ToList();
        }
        public List<ClassViewModel> GetClassesJoin()
        {
            List<ClassViewModel> classes = (from x in db.classes
                                               join s in db.specialities on x.id_speciality equals s.id_speciality
                                               join c in db.grades on x.id_grade equals c.id_grade
                                               select new ClassViewModel { Class = x, speciality = s, grade = c }).ToList();
            return classes;
        }
        public bool AddGrade(string grade_name)
        {
            var grade = new grade();
            grade.grade_name = grade_name;
            try
            {
                db.grades.Add(grade);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool AddClass(string class_name, int id_grade, int id_speciality)
        {
            var cl = new @class();
            cl.class_name = class_name;
            cl.id_grade = id_grade;
            cl.id_speciality = id_speciality;
            try
            {
                db.classes.Add(cl);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool DeleteClass(int id)
        {
            try
            {
                var delete = (from x in db.classes where x.id_class == id select x).Single();
                db.classes.Remove(delete);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public @class GetClass(int id)
        {
            @class cl = new @class();
            try
            {
                cl = db.classes.SingleOrDefault(x => x.id_class == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return cl;
        }
        public bool EditClass(int id_class, string class_name, int id_speciality, int id_grade)
        {
            try
            {
                var update = (from x in db.classes where x.id_class == id_class select x).Single();
                update.class_name = class_name;
                update.id_speciality = id_speciality;
                update.id_grade = id_grade;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool AddSpeciality(string speciality_name)
        {
            var speciality = new speciality();
            speciality.speciality_name = speciality_name;
            try
            {
                db.specialities.Add(speciality);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool DeleteSpeciality(int id)
        {
            try
            {
                var delete = (from x in db.specialities where x.id_speciality == id select x).Single();
                db.specialities.Remove(delete);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public speciality GetSpeciality(int id)
        {
            speciality speciality = new speciality();
            try
            {
                speciality = db.specialities.SingleOrDefault(x => x.id_speciality == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return speciality;
        }
        public bool EditSpeciality(int id_speciality, string speciality_name)
        {
            try
            {
                var update = (from x in db.specialities where x.id_speciality == id_speciality select x).Single();
                update.speciality_name = speciality_name;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public List<subject> GetSubjects()
        {
            return db.subjects.ToList();
        }
        public bool AddSubject(string subject_name)
        {
            var subject = new subject();
            subject.subject_name = subject_name;
            try
            {
                db.subjects.Add(subject);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool DeleteSubject(int id)
        {
            try
            {
                var delete = (from x in db.subjects where x.id_subject == id select x).Single();
                db.subjects.Remove(delete);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public subject GetSubject(int id)
        {
            subject subject = new subject();
            try
            {
                subject = db.subjects.SingleOrDefault(x => x.id_subject == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return subject;
        }
        public bool EditSubject(int id_subject, string subject_name)
        {
            try
            {
                var update = (from x in db.subjects where x.id_subject == id_subject select x).Single();
                update.subject_name = subject_name;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public List<QuestionViewModel> GetQuestions()
        {
            List<QuestionViewModel> questions = (from x in db.questions
                                               join s in db.subjects on x.id_subject equals s.id_subject
                                               select new QuestionViewModel { question = x, subject = s }).ToList();
            return questions;
        }
        public bool AddQuestion(int id_subject, int unit, string content, string img_content, string answer_a, string answer_b, string answer_c, string answer_d, string correct_answer)
        {
            var question = new question();
            question.id_subject = id_subject;
            question.unit = unit;
            question.content = content;
            question.img_content = img_content;
            question.answer_a = answer_a;
            question.answer_b = answer_b;
            question.answer_c = answer_c;
            question.answer_d = answer_d;
            question.correct_answer = correct_answer;
            try
            {
                db.questions.Add(question);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool DeleteQuestion(int id)
        {
            try
            {
                var delete = (from x in db.questions where x.id_question == id select x).Single();
                db.questions.Remove(delete);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public question GetQuestion(int id)
        {
            question question = new question();
            try
            {
                question = db.questions.SingleOrDefault(x => x.id_question == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return question;
        }
        public bool EditQuestion(int id_question, int id_subject, int unit, string content, string img_content, string answer_a, string answer_b, string answer_c, string answer_d, string correct_answer)
        {
            try
            {
                var update = (from x in db.questions where x.id_question == id_question select x).Single();
                update.id_subject = id_subject;
                update.unit = unit;
                update.content = content;
                update.img_content = img_content;
                update.answer_a = answer_a;
                update.answer_b = answer_b;
                update.answer_c = answer_c;
                update.answer_d = answer_d;
                update.correct_answer = correct_answer;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public List<TestViewModel> Tests()
        {
            List<TestViewModel> tests = (from x in db.tests
                                                 join s in db.subjects on x.id_subject equals s.id_subject
                                                 join stt in db.statuses on x.id_status equals stt.id_status
                                                 select new TestViewModel { test = x, subject = s, status = stt }).ToList();
            return tests;
        }
        public List<UnitViewModel> GetUnits(int id)
        {
            List<UnitViewModel> tests = db.questions
                   .Where(p => p.id_subject == id)
                   .GroupBy(p => p.unit)
                   .Select(g => new UnitViewModel { Unit = g.Key, Total = g.Count() }).ToList();
            return tests;
        }
        public bool AddTest(string test_name, string password, int test_code, int id_subject, int total_question, int time_to_do, string note)
        {
            var test = new test();
            test.test_name = test_name;
            test.password = password;
            test.test_code = test_code;
            test.id_subject = id_subject;
            test.id_status = 2;
            test.total_questions = total_question;
            test.time_to_do = time_to_do;
            test.note = note;
            try
            {
                db.tests.Add(test);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
                return false;
            }
            return true;
        }
        public test GetTest(int test_code)
        {
            test test = new test();
            try
            {
                test = db.tests.SingleOrDefault(x => x.test_code == test_code);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return test;
        }
        public bool EditTest(int test_code, string test_name, string password, int time_to_do, string note)
        {
            try
            {
                var update = (from x in db.tests where x.test_code == test_code select x).Single();
                update.test_name = test_name;
                update.time_to_do = time_to_do;
                update.note = note;
                if (password != "")
                    update.password = password;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool ToggleStatus(int id_test)
        {
            try
            {
                var update = (from x in db.tests where x.test_code == id_test select x).Single();
                if (update.id_status == 1)
                    update.id_status = 2;
                else
                    update.id_status = 1;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public List<question> GetQuestionsByUnit(int id_subject, int unit, int quest_of_unit)
        {
            List<question> q = (from x in db.questions
                                where x.id_subject == id_subject && x.unit == unit
                                select x).OrderBy(x => Guid.NewGuid()).Take(quest_of_unit).ToList();
            return q;
        }
        public bool AddQuestionsToTest(int test_code, int id_question)
        {
            var quest_of_test = new quests_of_test();
            quest_of_test.test_code = test_code;
            quest_of_test.id_question = id_question;
            try
            {
                db.quests_of_test.Add(quest_of_test);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
                return false;
            }
            return true;
        }
        public List<question> GetQuestionsOfTest(int test_code)
        {
            List<int> id_quest = (from x in db.quests_of_test
                                  where x.test_code == test_code
                                  select x.id_question).ToList();
            List<question> list_quest = new List<question>();
            foreach(int item in id_quest)
            {
                question q = (from x in db.questions
                                    where x.id_question == item
                                    select x).Single();
                list_quest.Add(q);
            }
            return list_quest;
        }

    }
}