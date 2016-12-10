using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.Model;

namespace TravelAgency.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Show(int id)
        {
            Hotel h = DataAccess.Hotels.GetById(id);
            var city = DataAccess.Cities.GetCity(h.CityId);
            h.CityName = city.Name;
            h.ProvinceName = DataAccess.Provinces.GetById(city.ProvinceId).Name;
            return View(h);
        }
    }
}