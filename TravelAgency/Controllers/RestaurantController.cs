using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.Model;

namespace TravelAgency.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Show(int id )
        {
            Restaurant r = DataAccess.Restaurants.GetById(id);
            return View(r);
        }
    }
}