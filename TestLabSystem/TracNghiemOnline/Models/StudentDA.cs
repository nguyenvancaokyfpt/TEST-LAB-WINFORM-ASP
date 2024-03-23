using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TracNghiemOnline.Common;
namespace TracNghiemOnline.Models
{
    public class StudentDA
    {
        User user = new User();
        trac_nghiem_onlineEntities db = new trac_nghiem_onlineEntities();

        public void UpdateLastLogin()
        {
            var update = (from x in db.students where x.id_student == user.ID select x).Single();
            update.last_login = DateTime.Now;
            db.SaveChanges();
        }
        public void UpdateLastSeen(string name, string url)
        {
            var update = (from x in db.students where x.id_student == user.ID select x).Single();
            update.last_seen = name;
            update.last_seen_url = url;
            db.SaveChanges();
        }
        public List<TestViewModel> GetDashboard()
        {
            List<TestViewModel> tests = (from x in db.tests
                                         join s in db.subjects on x.id_subject equals s.id_subject
                                         join stt in db.statuses on x.id_status equals stt.id_status
                                         select new TestViewModel { test = x, subject = s, status = stt }).ToList();
            return tests;
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
        public void UpdateStatus(int test_code, string time_remaining)
        {
            var update = (from x in db.students where x.id_student == user.ID select x).Single();
            update.is_testing = test_code;
            update.time_start = DateTime.Now;
            update.time_remaining = time_remaining;
            db.SaveChanges();
            HttpContext.Current.Session[UserSession.TESTCODE] = test_code;
            user.TESTCODE = test_code;
            HttpContext.Current.Session[UserSession.TIME] = time_remaining;
            user.TIME = time_remaining;
        }

        public void CreateStudentQuestion(int code)
        {
            List<quests_of_test> qs = (from x in db.quests_of_test
                                       where x.test_code == code
                                       select x).OrderBy(x => Guid.NewGuid()).ToList();
            foreach(var item in qs)
            {
                var StudentTest = new student_test_detail();
                StudentTest.id_question = item.id_question;
                StudentTest.test_code = code;
                StudentTest.id_student = user.ID;
                question q = db.questions.SingleOrDefault(x => x.id_question == item.id_question);
                string[] answer = {q.answer_a, q.answer_b, q.answer_c, q.answer_d};
                answer = ShuffleArray.Randomize(answer);
                StudentTest.answer_a = answer[0];
                StudentTest.answer_b = answer[1];
                StudentTest.answer_c = answer[2];
                StudentTest.answer_d = answer[3];
                db.student_test_detail.Add(StudentTest);
                db.SaveChanges();
            }

        }
        public List<StudentQuestViewModel> GetListQuest(int test_code)
        {
            List<StudentQuestViewModel> list = new List<StudentQuestViewModel>();
            try
            {
                list = (from x in db.student_test_detail
                        join t in db.tests on x.test_code equals t.test_code
                        join q in db.questions on x.id_question equals q.id_question
                        where x.test_code == test_code &&
                        x.id_student == user.ID
                        select new StudentQuestViewModel { test = t, student_test = x, question = q }).OrderBy(x => x.student_test.ID).ToList();
            } catch(Exception) { }
            return list;
        }
        public void UpdateTiming(string time)
        {
            var update = (from x in db.students where x.id_student == user.ID select x).Single();
            update.time_remaining = time;
            HttpContext.Current.Session[UserSession.TIME] = time;
            user.TIME = time;
            db.SaveChanges();
        }
        public void UpdateStudentTest(int id_question, string answer)
        {
            var update = (from x in db.student_test_detail where x.id_student == user.ID && x.test_code == user.TESTCODE && x.id_question == id_question select x).Single();
            update.student_answer = answer;
            db.SaveChanges();
        }
        public void InsertScore(double score, string detail)
        {
            var s = new score();
            s.id_student = user.ID;
            s.test_code = user.TESTCODE;
            s.score_number = score;
            s.detail = detail;
            s.time_finish = DateTime.Now;
            db.scores.Add(s);
            db.SaveChanges();
        }
        public void FinishTest()
        {
            var update = (from x in db.students where x.id_student == user.ID select x).Single();
            update.is_testing = null;
            update.time_remaining = null;
            update.time_start = null;
            db.SaveChanges();
            HttpContext.Current.Session[UserSession.TESTCODE] = 0;
            user.TESTCODE = 0;
            HttpContext.Current.Session[UserSession.TIME] = null;
            user.TIME = null;
        }
        public score GetScore(int test_code)
        {
            score score = new score();
            try
            {
                score = db.scores.SingleOrDefault(x => x.test_code == test_code && x.id_student == user.ID);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return score;
        }
        public List<int> GetStudentTestcode()
        {
            List<int> score = new List<int>();
            try
            {
                score = (from x in db.scores where x.id_student == user.ID select x.test_code).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return score;
        }
    }
}