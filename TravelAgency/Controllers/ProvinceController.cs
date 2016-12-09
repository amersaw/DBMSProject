using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelAgency.Controllers
{
    public class ProvinceController : Controller
    {
        // GET: Province
        public ActionResult Show(int id)
        {
            return View();
        }
    }
}