﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eQuiz.Modules.Web.Areas.User.Controllers
{
    public class UserMainController : Controller
    {
        // GET: User/UserMain
        public ActionResult StudentLogin()
        {
            return View();
        }

        public ActionResult StudentDetails()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Quizz()
        {
            return View();
        }
    }
}