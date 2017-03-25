using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashPickup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("Customer"))
            {
                return RedirectToAction("Home", "Customer");
            }
            if (User.IsInRole("Employee"))
            {
                return RedirectToAction("Home", "Employee");
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Trash Pick-Up Schedule";

            return View();
        }
    }
}