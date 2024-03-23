using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TracNghiemOnline.Common;
namespace TracNghiemOnline.Models
{
    public class TeacherDA
    {
        User user = new User();
        trac_nghiem_onlineEntities db = new trac_nghiem_onlineEntities();

        public void UpdateLastLogin()
        {
            var update = (from x in db.teachers where x.id_teacher == user.ID select x).Single();
            update.last_login = DateTime.Now;
            db.SaveChanges();
        }
        public void UpdateLastSeen(string name, string url)
        {
            var update = (from x in db.teachers where x.id_teacher == user.ID select x).Single();
            update.last_seen = name;
            update.last_seen_url = url;
            db.SaveChanges();
        }
        public List<TestViewModel> GetListTest()
        {
            List<TestViewModel> tests = (from x in db.tests
                                         join s in db.subjects on x.id_subject equals s.id_subject
                                         join stt in db.statuses on x.id_status equals stt.id_status
                                         select new TestViewModel { test = x, subject = s, status = stt }).ToList();
            return tests;
        }
        public List<ScoreViewModel> GetListScore(int test_code)
        {
            List<ScoreViewModel> score = new List<ScoreViewModel>();
            try
            {
                score = (from x in db.scores
                         join s in db.students on x.id_student equals s.id_student
                         where x.test_code == test_code select new ScoreViewModel { score = x, student = s }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return score;
        }
    }
}