﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechiesWeb.TeamBins.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult team(int id)
        {
            Session["TB_TeamID"] = id;
            return RedirectToAction("Index", "Issues");
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult GettingStarted()
        {
            return View();
        }
    }
}
