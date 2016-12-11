using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelAgency.Controllers
{
    public class TravelAgencyBranchController : Controller
    {
        public ActionResult Show(int id)
        {
            Model.TravelAgencyBranch r = DataAccess.TravelAgencyBranches.GetById(id);
            r.AgencyName = DataAccess.TravelAgencies.GetById(r.TravelAgencyId).Name;
            return View(r);
        }
    }
}