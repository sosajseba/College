using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using College.Models;

namespace College.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string User, string Pass)
        {
            Session["User"] = null;

            int userRole;
            int adminRole = 1;

            try
            {
                using (Test2Entities db = new Test2Entities())
                {
                    var oUser = (from d in db.user
                                 where d.dni == User.Trim() && d.file_number.ToString() == Pass
                                 select d).FirstOrDefault();

                    if (oUser == null)
                    {
                        ViewBag.Error = "Usuario o password invalido";
                        return View();
                    }

                    userRole = oUser.id_role;

                    Session["User"] = oUser;
                }

                if (userRole == adminRole)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return RedirectToAction("Class", "Student");
                }

            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return View();
            }
        }
    }
}