using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelAgency.Controllers
{
    public class TouristicSiteController : Controller
    {
        // GET: TouristicSite
        public ActionResult Show(int id )
        {
            var s = DataAccess.TouristicSites.GetById(id);
            return View(s);
        }
    }
}