using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.Model;

namespace TravelAgency.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Show(int id)
        {
            City city = DataAccess.Cities.GetCity(id);
            return View(city);
        }
    }
}