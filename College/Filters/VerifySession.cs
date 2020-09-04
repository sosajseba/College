using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using College.Controllers;
using College.Models;

namespace College.Filters
{
    public class VerifySession : ActionFilterAttribute
    {
        private user oUser;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);

                oUser = (user)HttpContext.Current.Session["User"];

                if (oUser == null)
                {
                    if (filterContext.Controller is AccessController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("/Access/Login");
                    }
                }
            }
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("~/Access/Login");
            }

        }
    }
}