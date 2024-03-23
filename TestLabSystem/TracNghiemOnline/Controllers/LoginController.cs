using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TracNghiemOnline.Models;
using TracNghiemOnline.Common;
namespace TracNghiemOnline.Controllers
{
    public class LoginController : Controller
    {
        User user;
        // GET: Login
        public ActionResult Index()
        {
            if (Session[UserSession.ISLOGIN] != null && (bool)Session[UserSession.ISLOGIN])
            {
                if ((int)Session[UserSession.PERMISSION] == 1)
                    return RedirectToAction("Index", "Admin");
                if ((int)Session[UserSession.PERMISSION] == 2)
                    return RedirectToAction("Index", "Teacher");
                if ((int)Session[UserSession.PERMISSION] == 3)
                    return RedirectToAction("Index", "Student");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                if (model.IsValid(model))
                {
                    user = new User();
                    if (user.IsAdmin())
                        return RedirectToAction("Index", "Admin");
                    if (user.IsTeacher())
                        return RedirectToAction("Index", "Teacher");
                    if (user.IsStudent())
                        return RedirectToAction("Index", "Student");
                }
                else
                    ViewBag.error = "Tài khoản hoặc mật khẩu không đúng";
            } else
                ViewBag.error = "Có lỗi xảy ra trong quá trình xử lý, vui lòng thử lại sau.";
            return View();
        }
    }
}