using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.Model;

namespace TravelAgency.Controllers
{
    public class TravelAgencyController : Controller
    {
        // GET: TravelAgency

        public ActionResult Show(int id)
        {
            Model.TravelAgency r = DataAccess.TravelAgencies.GetById(id);
            r.Branches = DataAccess.TravelAgencyBranches.GetAgencyBranches(id);
            foreach (var b in r.Branches)
                b.CityName = DataAccess.Cities.GetCity(b.CityId).Name;
            return View(r);
        }
    }
}