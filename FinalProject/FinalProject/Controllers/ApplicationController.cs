﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexOld()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}