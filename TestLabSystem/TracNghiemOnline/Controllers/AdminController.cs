using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using TracNghiemOnline.Models;
using TracNghiemOnline.Common;
namespace TracNghiemOnline.Controllers
{
    public class AdminController : Controller
    {
        User user = new User();
        // GET: Admin
        AdminDA Model = new AdminDA();

        public ActionResult Index()
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastLogin();
            Model.UpdateLastSeen("Trang Chủ", Url.Action("Index"));
            Dictionary<string, int> ListCount = Model.GetDashBoard();
            return View(ListCount);
        }
        public ActionResult Logout()
        {
            if (!user.IsAdmin())
                return View("Error");
            user.Reset();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult AdminManager()
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Quản Lý Admin", Url.Action("AdminManager"));
            return View(Model.GetAdmins());
        }
        [HttpPost]
        public ActionResult AddAdmin(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Thêm Admin", Url.Action("AddAdmin"));
            string name = form["name"];
            string username = form["username"];
            string password = form["password"];
            string email = form["email"];
            string gender = form["gender"];
            string birthday = form["birthday"];
            bool add = Model.AddAdmin(name,username,password,gender,email,birthday);
            if(add)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Thêm Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Thêm Thất Bại";
            }
            return RedirectToAction("AdminManager");
        }
        public ActionResult DeleteAdmin(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Admin", Url.Action("DeleteAdmin"));
            int id_admin = Convert.ToInt32(id);
            bool del = Model.DeleteAdmin(id_admin);
            if (del)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Xóa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Xóa Thất Bại";
            }
            return RedirectToAction("AdminManager");
        }
        [HttpPost]
        public ActionResult DeleteAdmin(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Admin", Url.Action("DeleteAdmin"));
            string[] ids = Regex.Split(form["checkbox"], ",");
            TempData["status_id"] = true;
            TempData["status"] = "Xóa Thất Bại ID: ";
            foreach (string id in ids)
            {
                int id_admin = Convert.ToInt32(id);
                bool del = Model.DeleteAdmin(id_admin);
                if (!del)
                {
                    TempData["status_id"] = false;
                    TempData["status"] += id_admin.ToString() + ",";
                }
            }
            if((bool)TempData["status_id"])
            {
                TempData["status"] = "Xóa Thành Công";
            }
            return RedirectToAction("AdminManager");
        }
        public ActionResult EditAdmin(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_admin = Convert.ToInt32(id);
            try
            {
                admin admin = Model.GetAdmin(id_admin);
                Model.UpdateLastSeen("Sửa Admin " + admin.name, Url.Action("EditAdmin/" + id));
                return View(admin);
            } catch(Exception)
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult EditAdmin(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_admin = Convert.ToInt32(form["id_admin"]);
            string name = form["name"];
            string username = form["username"];
            string password = form["password"];
            string email = form["email"];
            string gender = form["gender"];
            string birthday = form["birthday"];
            bool edit = Model.EditAdmin(id_admin, name, username, password, gender, email, birthday);
            if (edit)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Sửa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Sửa Thất Bại";
            }
            return RedirectToAction("EditAdmin/"+id_admin);
        }
        public ActionResult TeacherManager()
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Quản Lý Giáo Viên", Url.Action("TeacherManager"));
            ViewBag.ListSpecialities = Model.GetSpecialities();
            return View(Model.GetTeachers());
        }
        [HttpPost]
        public ActionResult AddTeacher(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Thêm Giảng Viên", Url.Action("AddTeacher"));
            string name = form["name"];
            string username = form["username"];
            string password = form["password"];
            string email = form["email"];
            string gender = form["gender"];
            string birthday = form["birthday"];
            int id_speciality = Convert.ToInt32(form["id_speciality"]);
            bool add = Model.AddTeacher(name, username, password, gender, email, birthday, id_speciality);
            if (add)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Thêm Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Thêm Thất Bại";
            }
            return RedirectToAction("TeacherManager");
        }
        public ActionResult DeleteTeacher(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Giảng Viên", Url.Action("DeleteTeacher"));
            int id_teacher = Convert.ToInt32(id);
            bool del = Model.DeleteTeacher(id_teacher);
            if (del)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Xóa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Xóa Thất Bại";
            }
            return RedirectToAction("TeacherManager");
        }
        [HttpPost]
        public ActionResult DeleteTeacher(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Giảng Viên", Url.Action("DeleteTeacher"));
            string[] ids = Regex.Split(form["checkbox"], ",");
            TempData["status_id"] = true;
            TempData["status"] = "Xóa Thất Bại ID: ";
            foreach (string id in ids)
            {
                int id_teacher = Convert.ToInt32(id);
                bool del = Model.DeleteTeacher(id_teacher);
                if (!del)
                {
                    TempData["status_id"] = false;
                    TempData["status"] += id_teacher.ToString() + ",";
                }
            }
            if ((bool)TempData["status_id"])
            {
                TempData["status"] = "Xóa Thành Công";
            }
            return RedirectToAction("TeacherManager");
        }
        public ActionResult EditTeacher(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_teacher = Convert.ToInt32(id);
            try
            {
                teacher teacher = Model.GetTeacher(id_teacher);
                Model.UpdateLastSeen("Sửa Giảng Viên " + teacher.name, Url.Action("EditTeacher/" + id));
                ViewBag.ListSpecialities = Model.GetSpecialities();
                return View(teacher);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult EditTeacher(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_teacher = Convert.ToInt32(form["id_teacher"]);
            string name = form["name"];
            string username = form["username"];
            string password = form["password"];
            string email = form["email"];
            string gender = form["gender"];
            string birthday = form["birthday"];
            int id_speciality = Convert.ToInt32(form["id_speciality"]);
            bool edit = Model.EditTeacher(id_teacher, name, username, password, gender, email, birthday, id_speciality);
            if (edit)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Sửa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Sửa Thất Bại";
            }
            return RedirectToAction("EditTeacher/" + id_teacher);
        }
        public ActionResult StudentManager()
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Quản Lý Sinh Viên", Url.Action("StudentManager"));
            ViewBag.ListSpecialities = Model.GetSpecialities();
            ViewBag.ListClass = Model.GetClasses();
            return View(Model.GetStudents());
        }
        [HttpPost]
        public ActionResult AddStudent(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Thêm Sinh Viên", Url.Action("AddStudent"));
            string name = form["name"];
            string username = form["username"];
            string password = form["password"];
            string email = form["email"];
            string gender = form["gender"];
            string birthday = form["birthday"];
            int id_speciality = Convert.ToInt32(form["id_speciality"]);
            int id_class = Convert.ToInt32(form["id_class"]);
            bool add = Model.AddStudent(name, username, password, gender, email, birthday, id_speciality, id_class);
            if (add)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Thêm Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Thêm Thất Bại";
            }
            return RedirectToAction("StudentManager");
        }
        public ActionResult DeleteStudent(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Sinh Viên", Url.Action("DeleteStudent"));
            int id_student = Convert.ToInt32(id);
            bool del = Model.DeleteStudent(id_student);
            if (del)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Xóa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Xóa Thất Bại";
            }
            return RedirectToAction("StudentManager");
        }
        [HttpPost]
        public ActionResult DeleteStudent(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Sinh Viên", Url.Action("DeleteStudent"));
            string[] ids = Regex.Split(form["checkbox"], ",");
            TempData["status_id"] = true;
            TempData["status"] = "Xóa Thất Bại ID: ";
            foreach (string id in ids)
            {
                int id_student = Convert.ToInt32(id);
                bool del = Model.DeleteStudent(id_student);
                if (!del)
                {
                    TempData["status_id"] = false;
                    TempData["status"] += id_student.ToString() + ",";
                }
            }
            if ((bool)TempData["status_id"])
            {
                TempData["status"] = "Xóa Thành Công";
            }
            return RedirectToAction("StudentManager");
        }
        public ActionResult EditStudent(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_student = Convert.ToInt32(id);
            try
            {
                student student = Model.GetStudent(id_student);
                Model.UpdateLastSeen("Sửa Sinh Viên " + student.name, Url.Action("EditStudent/" + id));
                ViewBag.ListSpecialities = Model.GetSpecialities();
                ViewBag.ListClass = Model.GetClasses();
                return View(student);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult EditStudent(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_student = Convert.ToInt32(form["id_student"]);
            string name = form["name"];
            string username = form["username"];
            string password = form["password"];
            string email = form["email"];
            string gender = form["gender"];
            string birthday = form["birthday"];
            int id_speciality = Convert.ToInt32(form["id_speciality"]);
            int id_class = Convert.ToInt32(form["id_class"]);
            bool edit = Model.EditStudent(id_student, name, username, password, gender, email, birthday, id_speciality, id_class);
            if (edit)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Sửa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Sửa Thất Bại";
            }
            return RedirectToAction("EditStudent/" + id_student);
        }
        public ActionResult ClassManager()
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Quản Lý Khóa/Lớp", Url.Action("ClassManager"));
            ViewBag.ListSpecialities = Model.GetSpecialities();
            ViewBag.ListGrades = Model.GetGrades();
            return View(Model.GetClassesJoin());
        }
        [HttpPost]
        public ActionResult AddGrade(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Thêm Khóa", Url.Action("AddGrade"));
            string grade_name = form["grade_name"];
            bool add = Model.AddGrade(grade_name);
            if (add)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Thêm Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Thêm Thất Bại";
            }
            return RedirectToAction("ClassManager");
        }
        [HttpPost]
        public ActionResult AddClass(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Thêm Khóa", Url.Action("AddGrade"));
            string class_name = form["class_name"];
            int id_speciality = Convert.ToInt32(form["id_speciality"]);
            int id_grade = Convert.ToInt32(form["id_grade"]);
            bool add = Model.AddClass(class_name, id_grade, id_speciality);
            if (add)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Thêm Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Thêm Thất Bại";
            }
            return RedirectToAction("ClassManager");
        }
        public ActionResult DeleteClass(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Lớp", Url.Action("DeleteClass"));
            int id_class = Convert.ToInt32(id);
            bool del = Model.DeleteClass(id_class);
            if (del)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Xóa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Xóa Thất Bại";
            }
            return RedirectToAction("ClassManager");
        }
        [HttpPost]
        public ActionResult DeleteClass(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Lớp", Url.Action("DeleteClass"));
            string[] ids = Regex.Split(form["checkbox"], ",");
            TempData["status_id"] = true;
            TempData["status"] = "Xóa Thất Bại ID: ";
            foreach (string id in ids)
            {
                int id_class = Convert.ToInt32(id);
                bool del = Model.DeleteClass(id_class);
                if (!del)
                {
                    TempData["status_id"] = false;
                    TempData["status"] += id_class.ToString() + ",";
                }
            }
            if ((bool)TempData["status_id"])
            {
                TempData["status"] = "Xóa Thành Công";
            }
            return RedirectToAction("ClassManager");
        }
        public ActionResult EditClass(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_class = Convert.ToInt32(id);
            try
            {
                @class cl = Model.GetClass(id_class);
                Model.UpdateLastSeen("Sửa Lớp " + cl.class_name, Url.Action("EditClass/" + id));
                ViewBag.ListSpecialities = Model.GetSpecialities();
                ViewBag.ListGrades = Model.GetGrades();
                return View(cl);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult EditClass(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_class = Convert.ToInt32(form["id_class"]);
            string class_name = form["class_name"];
            int id_speciality = Convert.ToInt32(form["id_speciality"]);
            int id_grade = Convert.ToInt32(form["id_grade"]);
            bool edit = Model.EditClass(id_class, class_name, id_speciality, id_grade);
            if (edit)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Sửa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Sửa Thất Bại";
            }
            return RedirectToAction("EditClass/" + id_class);
        }
        public ActionResult SpecialityManager()
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Quản Lý Ngành", Url.Action("SpecialityManager"));
            return View(Model.GetSpecialities());
        }
        [HttpPost]
        public ActionResult AddSpeciality(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Thêm Ngành", Url.Action("AddSpeciality"));
            string speciality_name = form["speciality_name"];
            bool add = Model.AddSpeciality(speciality_name);
            if (add)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Thêm Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Thêm Thất Bại";
            }
            return RedirectToAction("SpecialityManager");
        }
        public ActionResult DeleteSpeciality(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Ngành", Url.Action("DeleteSpeciality"));
            int id_speciality = Convert.ToInt32(id);
            bool del = Model.DeleteSpeciality(id_speciality);
            if (del)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Xóa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Xóa Thất Bại";
            }
            return RedirectToAction("SpecialityManager");
        }
        [HttpPost]
        public ActionResult DeleteSpeciality(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Ngành", Url.Action("DeleteSpeciality"));
            string[] ids = Regex.Split(form["checkbox"], ",");
            TempData["status_id"] = true;
            TempData["status"] = "Xóa Thất Bại ID: ";
            foreach (string id in ids)
            {
                int id_speciality = Convert.ToInt32(id);
                bool del = Model.DeleteSpeciality(id_speciality);
                if (!del)
                {
                    TempData["status_id"] = false;
                    TempData["status"] += id_speciality.ToString() + ",";
                }
            }
            if ((bool)TempData["status_id"])
            {
                TempData["status"] = "Xóa Thành Công";
            }
            return RedirectToAction("SpecialityManager");
        }
        public ActionResult EditSpeciality(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_speciality = Convert.ToInt32(id);
            try
            {
                speciality speciality = Model.GetSpeciality(id_speciality);
                Model.UpdateLastSeen("Sửa Ngành " + speciality.speciality_name, Url.Action("EditSpeciality/" + id));
                return View(speciality);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult EditSpeciality(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_speciality = Convert.ToInt32(form["id_speciality"]);
            string speciality_name = form["speciality_name"];
            bool edit = Model.EditSpeciality(id_speciality, speciality_name);
            if (edit)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Sửa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Sửa Thất Bại";
            }
            return RedirectToAction("EditSpeciality/" + id_speciality);
        }
        public ActionResult SubjectManager()
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Quản Lý Môn", Url.Action("SubjectManager"));
            return View(Model.GetSubjects());
        }
        [HttpPost]
        public ActionResult AddSubject(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Thêm Môn", Url.Action("AddSubject"));
            string subject_name = form["subject_name"];
            bool add = Model.AddSubject(subject_name);
            if (add)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Thêm Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Thêm Thất Bại";
            }
            return RedirectToAction("SubjectManager");
        }
        public ActionResult DeleteSubject(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Môn", Url.Action("DeleteSubject"));
            int id_subject = Convert.ToInt32(id);
            bool del = Model.DeleteSubject(id_subject);
            if (del)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Xóa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Xóa Thất Bại";
            }
            return RedirectToAction("SubjectManager");
        }
        [HttpPost]
        public ActionResult DeleteSubject(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Môn", Url.Action("DeleteSubject"));
            string[] ids = Regex.Split(form["checkbox"], ",");
            TempData["status_id"] = true;
            TempData["status"] = "Xóa Thất Bại ID: ";
            foreach (string id in ids)
            {
                int id_subject = Convert.ToInt32(id);
                bool del = Model.DeleteSubject(id_subject);
                if (!del)
                {
                    TempData["status_id"] = false;
                    TempData["status"] += id_subject.ToString() + ",";
                }
            }
            if ((bool)TempData["status_id"])
            {
                TempData["status"] = "Xóa Thành Công";
            }
            return RedirectToAction("SubjectManager");
        }
        public ActionResult EditSubject(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_subject = Convert.ToInt32(id);
            try
            {
                subject subject = Model.GetSubject(id_subject);
                Model.UpdateLastSeen("Sửa Môn " + subject.subject_name, Url.Action("EditSubject/" + id));
                return View(subject);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult EditSubject(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_subject = Convert.ToInt32(form["id_subject"]);
            string subject_name = form["subject_name"];
            bool edit = Model.EditSubject(id_subject, subject_name);
            if (edit)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Sửa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Sửa Thất Bại";
            }
            return RedirectToAction("EditSubject/" + id_subject);
        }
        public ActionResult QuestionManager()
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Quản Lý Câu Hỏi", Url.Action("QuestionManager"));
            ViewBag.ListSubject = Model.GetSubjects();
            return View(Model.GetQuestions());
        }
        [HttpPost]
        public ActionResult AddQuestion(FormCollection form, HttpPostedFileBase File)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Thêm Câu Hỏi", Url.Action("AddQuestion"));
            int id_subject = Convert.ToInt32(form["id_subject"]);
            int unit = Convert.ToInt32(form["unit"]);
            string content = form["content"];
            string[] answer = new string[] {
                form["answer_a"],
                form["answer_b"],
                form["answer_c"],
                form["answer_d"]
            };
            answer = Common.ShuffleArray.Randomize(answer);
            string answer_a = answer[0];
            string answer_b = answer[1];
            string answer_c = answer[2];
            string answer_d = answer[3];
            string correct_answer = form["correct_answer"];
            string img_content = "noimage.png";

            try
            {
                string fileName = Path.GetFileName(File.FileName);
                //Upload image
                string path = Server.MapPath("~/Assets/img_questions/");
                //Đuối hỗ trợ
                var allowedExtensions = new[] { ".png", ".jpg" };
                //Lấy phần mở rộng của file
                string extensionName = Path.GetExtension(File.FileName).ToLower();
                //Kiểm tra đuôi file
                if (!allowedExtensions.Contains(extensionName))
                {
                    TempData["status_id"] = false;
                    TempData["status"] = "Chỉ chọn file ảnh đuôi .PNG .png .JPG .jpg";
                    return RedirectToAction("QuestionManager");
                }
                else
                {
                    // Tạo tên file ngẫu nhiên
                    img_content = DateTime.Now.Ticks.ToString() + extensionName;
                    // Upload file lên server
                    File.SaveAs(path + img_content);
                }

            } catch (Exception) { }
            bool add = Model.AddQuestion(id_subject, unit, content, img_content, answer_a, answer_b, answer_c, answer_d, correct_answer);
            if (add)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Thêm Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Thêm Thất Bại";
            }
            return RedirectToAction("QuestionManager");
        }
        public ActionResult DeleteQuestion(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Câu Hỏi", Url.Action("DeleteQuestion"));
            int id_question = Convert.ToInt32(id);
            bool del = Model.DeleteQuestion(id_question);
            if (del)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Xóa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Xóa Thất Bại";
            }
            return RedirectToAction("QuestionManager");
        }
        [HttpPost]
        public ActionResult DeleteQuestion(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Xóa Câu Hỏi", Url.Action("DeleteQuestion"));
            string[] ids = Regex.Split(form["checkbox"], ",");
            TempData["status_id"] = true;
            TempData["status"] = "Xóa Thất Bại ID: ";
            foreach (string id in ids)
            {
                int id_question = Convert.ToInt32(id);
                bool del = Model.DeleteQuestion(id_question);
                if (!del)
                {
                    TempData["status_id"] = false;
                    TempData["status"] += id_question.ToString() + ",";
                }
            }
            if ((bool)TempData["status_id"])
            {
                TempData["status"] = "Xóa Thành Công";
            }
            return RedirectToAction("QuestionManager");
        }
        public ActionResult EditQuestion(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_question = Convert.ToInt32(id);
            try
            {
                question question = Model.GetQuestion(id_question);
                Model.UpdateLastSeen("Sửa Câu Hỏi " + question.id_question, Url.Action("EditQuestion/" + id));
                ViewBag.ListSubject = Model.GetSubjects();
                return View(question);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult EditQuestion(FormCollection form, HttpPostedFileBase File)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_question = Convert.ToInt32(form["id_question"]);
            int id_subject = Convert.ToInt32(form["id_subject"]);
            int unit = Convert.ToInt32(form["unit"]);
            string content = form["content"];
            string[] answer = new string[] {
                form["answer_a"],
                form["answer_b"],
                form["answer_c"],
                form["answer_d"]
            };
            //Không cần đảo thứ tự đáp án trong phần sửa
            //answer = Common.ShuffleArray.Randomize(answer);
            string answer_a = answer[0];
            string answer_b = answer[1];
            string answer_c = answer[2];
            string answer_d = answer[3];
            string correct_answer = form["correct_answer"];
            string img_content = "noimage.png";

            try
            {
                string fileName = Path.GetFileName(File.FileName);
                //Upload image
                string path = Server.MapPath("~/Assets/img_questions/");
                //Đuối hỗ trợ
                var allowedExtensions = new[] { ".png", ".jpg" };
                //Lấy phần mở rộng của file
                string extensionName = Path.GetExtension(File.FileName).ToLower();
                //Kiểm tra đuôi file
                if (!allowedExtensions.Contains(extensionName))
                {
                    TempData["status_id"] = false;
                    TempData["status"] = "Chỉ chọn file ảnh đuôi .PNG .png .JPG .jpg";
                    return RedirectToAction("QuestionManager");
                }
                else
                {
                    // Tạo tên file ngẫu nhiên
                    img_content = DateTime.Now.Ticks.ToString() + extensionName;
                    // Upload file lên server
                    File.SaveAs(path + img_content);
                }

            }
            catch (Exception) { }
            bool edit = Model.EditQuestion(id_question, id_subject, unit, content, img_content, answer_a, answer_b, answer_c, answer_d, correct_answer);
            if (edit)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Sửa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Sửa Thất Bại";
            }
            return RedirectToAction("EditQuestion/" + id_question);
        }
        public ActionResult TestManager()
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Quản Lý Bài Thi", Url.Action("TestManager"));
            ViewBag.ListSubject = Model.GetSubjects();
            return View(Model.Tests());
        }
        public JsonResult GetJsonUnits(int id)
        {
            return Json(Model.GetUnits(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult AddTest(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            Model.UpdateLastSeen("Thêm Đề Thi", Url.Action("AddTest"));
            //tạo đề thi
            string test_name = form["test_name"];
            string password = Common.Encryptor.MD5Hash(form["password"]);
            //sinh số test code ngẫu nhiên
            Random rnd = new Random();
            int test_code = rnd.Next(111111,999999);
            int id_subject = Convert.ToInt32(form["id_subject"]);
            int total_question = Convert.ToInt32(form["total_question"]);
            int time_to_do = Convert.ToInt32(form["time_to_do"]);
            string note = "";
            if (form["note"]!="")
                note = form["note"];
            bool add = Model.AddTest(test_name, password, test_code, id_subject, total_question, time_to_do, note);
            if (add)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Thêm Thành Công";
                //tạo bộ câu hỏi cho đề thi
                List<UnitViewModel> list_unit = Model.GetUnits(id_subject);
                foreach (UnitViewModel unit in list_unit)
                {
                    int quest_of_unit = Convert.ToInt32(form["unit-" + unit.Unit]);
                    List<question> list_question = Model.GetQuestionsByUnit(id_subject, unit.Unit, quest_of_unit);
                    foreach (question item in list_question)
                    {
                        Model.AddQuestionsToTest(test_code,item.id_question);
                    }
                }
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Thêm Thất Bại";
            }
            return RedirectToAction("TestManager");
        }
        public ActionResult EditTest(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int test_code = Convert.ToInt32(id);
            try
            {
                test test = Model.GetTest(test_code);
                Model.UpdateLastSeen("Sửa Đề Thi " + test.test_code, Url.Action("EditTest/" + id));
                return View(test);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
        [HttpPost]
        public ActionResult EditTest(FormCollection form)
        {
            if (!user.IsAdmin())
                return View("Error");
            int test_code = Convert.ToInt32(form["test_code"]);
            string test_name = form["test_name"];
            string password = "";
            if (form["password"] != "")
                password = Common.Encryptor.MD5Hash(form["password"]);
            int id_subject = Convert.ToInt32(form["id_subject"]);
            int time_to_do = Convert.ToInt32(form["time_to_do"]);
            string note = "";
            if (form["note"] != "")
                note = form["note"];
            bool edit = Model.EditTest(test_code, test_name, password, time_to_do, note);
            if (edit)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Sửa Thành Công";
            }
            else
            {
                TempData["status_id"] = false;
                TempData["status"] = "Sửa Thất Bại";
            }
            return RedirectToAction("EditTest/" + test_code);
        }
        public ActionResult ToggleStatus(int id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int id_test = Convert.ToInt32(id);
            bool toggle = Model.ToggleStatus(id_test);
            if (toggle)
            {
                TempData["status_id"] = true;
                TempData["status"] = "Đã Thay Đổi Trạng Thái Đề Thi " + id_test;
            }
            return RedirectToAction("TestManager/" + id_test);
        }
        public ActionResult TestDetail(string id)
        {
            if (!user.IsAdmin())
                return View("Error");
            int test_code = Convert.ToInt32(id);
            try
            {
                Model.UpdateLastSeen("Chi Tiết Đề Thi " + test_code, Url.Action("TestDetail/" + test_code));
                ViewBag.test_code = test_code;
                return View(Model.GetQuestionsOfTest(test_code));
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}