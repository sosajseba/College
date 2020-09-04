using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using College.Filters;

namespace TestCollege.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [AuthorizeUser(idRole: 1)]
        public ActionResult Index()
        {
            return View();
        }
    }
}