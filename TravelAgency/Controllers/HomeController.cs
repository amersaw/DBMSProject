﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelAgency.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.TravelAgencies = DataAccess.TravelAgencies.GetAll();
            return View(TravelAgency.DataAccess.Provinces.GetAll());
        }
    }
}