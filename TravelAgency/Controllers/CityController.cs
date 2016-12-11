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
            city.Hotels = DataAccess.Hotels.GetCityHotels(id);
            city.TouristicSites= DataAccess.TouristicSites.GetCityTouristicSites(id);
            city.Restaurants= DataAccess.Restaurants.GetCityRestaurants(id);
            city.TravelAgencyBranches = DataAccess.TravelAgencyBranches.GetCityBranches(id);

            return View(city);
        }
    }
}