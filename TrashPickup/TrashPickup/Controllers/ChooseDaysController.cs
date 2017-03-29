using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class ChooseDaysController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ChooseDays
        public ActionResult Index()
        {
            var chooseDays = db.ChooseDays.Include(c => c.DayOfWeek);
            return View(chooseDays.ToList());
        }

        // GET: ChooseDays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChooseDay chooseDay = db.ChooseDays.Find(id);
            if (chooseDay == null)
            {
                return HttpNotFound();
            }
            return View(chooseDay);
        }

        // GET: ChooseDays/Create
        public ActionResult Create()
        {
            ViewBag.DayId = new SelectList(db.Days, "DayId", "DayOfWeek");
            return View();
        }

        // POST: ChooseDays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ChooseDayId,DayId")] ChooseDay chooseDay)
        {
            if (ModelState.IsValid)
            {
                //User.Identity. = chooseDay.DayId;
                //db.ChooseDays.Add(chooseDay);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DayId = new SelectList(db.Days, "DayId", "DayOfWeek", chooseDay.DayId);
            return View(chooseDay);
        }

        // GET: ChooseDays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChooseDay chooseDay = db.ChooseDays.Find(id);
            if (chooseDay == null)
            {
                return HttpNotFound();
            }
            ViewBag.DayId = new SelectList(db.Days, "DayId", "DayOfWeek", chooseDay.DayId);
            return View(chooseDay);
        }

        // POST: ChooseDays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ChooseDayId,DayId")] ChooseDay chooseDay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chooseDay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DayId = new SelectList(db.Days, "DayId", "DayOfWeek", chooseDay.DayId);
            return View(chooseDay);
        }

        // GET: ChooseDays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChooseDay chooseDay = db.ChooseDays.Find(id);
            if (chooseDay == null)
            {
                return HttpNotFound();
            }
            return View(chooseDay);
        }

        // POST: ChooseDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChooseDay chooseDay = db.ChooseDays.Find(id);
            db.ChooseDays.Remove(chooseDay);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
