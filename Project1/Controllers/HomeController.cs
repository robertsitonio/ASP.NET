﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult RobertContact()
        {
            ViewBag.Message = "Robert's page.";
            if (ViewBag.Message=="Robert's page.") { ViewBag.Message = "Robert's new page."; }
            return View();
        }
    }

}