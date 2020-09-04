using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using College.Filters;
using College.Models;

namespace College.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [AuthorizeUser(idRole: 2)]
        public ActionResult Class()
        {
            try
            {
                using (Test2Entities db = new Test2Entities())
                {
                    var oClass = (from c in db.@class
                                  join s in db.subject
                                  on c.id_subject equals s.id
                                  join p in db.professor
                                  on c.id_professor equals p.id
                                  join d in db.day
                                  on c.id_day equals d.id
                                  select new Classroom()
                                  {
                                      Subject = s.name,
                                      ProfessorName = p.name,
                                      ProfessorSurname = p.surname,
                                      Day = d.name,
                                      StartTime = c.start_time.ToString(),
                                      EndTime = c.end_time.ToString(),
                                      Capacity = c.capacity
                                  });

                    return View(oClass.ToList());
                }
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
                return RedirectToAction("Login", "Access");
            }

        }
    }
}