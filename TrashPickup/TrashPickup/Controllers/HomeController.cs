using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Migrations;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("Customers"))
            {
                return RedirectToAction("Home", "Customers");
            }
            if (User.IsInRole("Employee"))
            {
                return RedirectToAction("Home", "Employee");
            }
            //List<SelectListItem> listItem = new List<SelectListItem>();
            //DropDown drop = new DropDown();
            ////ViewBag.DropDownValues = new SelectList(new[] { "First Value", "Second Value", "Third Value" });
            //drop.Id = 1;
            //drop.Value = "First Value";

            //listItem.Add(new SelectListItem() { Value = drop.Value, Text = drop.Id.ToString() });

            //ViewBag.DropDownValues = new SelectList(listItem, "Text", "Value");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Select what day of the week you want your trash to be picked up";
            List<SelectListItem> listItem = new List<SelectListItem>();
            DropDown drop = new DropDown();
            //ViewBag.DropDownValues = new SelectList(new[] { "First Value", "Second Value", "Third Value" });
            drop.Id = 1;
            drop.Value = "Sunday";


            listItem.Add(new SelectListItem() { Value = drop.Value, Text = drop.Id.ToString() });

            drop.Id = 2;
            drop.Value = "Monday";

            listItem.Add(new SelectListItem() { Value = drop.Value, Text = drop.Id.ToString() });

            drop.Id = 3;
            drop.Value = "Tuesday";

            listItem.Add(new SelectListItem() { Value = drop.Value, Text = drop.Id.ToString() });

            drop.Id = 4;
            drop.Value = "Wednesday";

            listItem.Add(new SelectListItem() { Value = drop.Value, Text = drop.Id.ToString() });

            drop.Id = 5;
            drop.Value = "Thursday";

            listItem.Add(new SelectListItem() { Value = drop.Value, Text = drop.Id.ToString() });

            drop.Id = 6;
            drop.Value = "Friday";

            listItem.Add(new SelectListItem() { Value = drop.Value, Text = drop.Id.ToString() });

            drop.Id = 7;
            drop.Value = "Saturday";

            listItem.Add(new SelectListItem() { Value = drop.Value, Text = drop.Id.ToString() });

            ViewBag.DropDownValues = new SelectList(listItem, "Text", "Value");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Trash Pick-Up Schedule";

            return View();
        }
    }
}