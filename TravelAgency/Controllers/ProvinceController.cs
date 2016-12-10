using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.Model;

namespace TravelAgency.Controllers
{
    public class ProvinceController : Controller
    {
        // GET: Province
        public ActionResult Show(int id)
        {
            Province province = DataAccess.Provinces.GetById(id);
            province.CalculatedPopulation = DataAccess.Provinces.GetTotalPopulation(id);
            province.Cities = DataAccess.Cities.GetProvinceCities(id);
            return View(province);
        }
    }
}