using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eQuiz.Modules.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult MainLogin()
        {
            return View();
        }
    }
}