using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T3.Models;

namespace T3.Controllers
{
    public class DiaDiemController : Controller
    {
        private TourDBEntities db = new TourDBEntities();

        //
        // GET: /DiaDiem/

        public ActionResult Index()
        {
            return View(db.DiaDiems.ToList());
        }

        //
        // GET: /DiaDiem/Details/5

        public ActionResult Details(int id = 0)
        {
            DiaDiem diadiem = db.DiaDiems.Find(id);
            if (diadiem == null)
            {
                return HttpNotFound();
            }
            return View(diadiem);
        }

        //
        // GET: /DiaDiem/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DiaDiem/Create

        [HttpPost]
        public ActionResult Create(DiaDiem diadiem)
        {
            if (ModelState.IsValid)
            {
                db.DiaDiems.Add(diadiem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diadiem);
        }

        //
        // GET: /DiaDiem/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DiaDiem diadiem = db.DiaDiems.Find(id);
            if (diadiem == null)
            {
                return HttpNotFound();
            }
            return View(diadiem);
        }

        //
        // POST: /DiaDiem/Edit/5

        [HttpPost]
        public ActionResult Edit(DiaDiem diadiem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diadiem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diadiem);
        }

        //
        // GET: /DiaDiem/Delete/5

        public ActionResult Delete(int id = 0)
        {
            /*
            DiaDiem diadiem = db.DiaDiems.Find(id);
            if (diadiem == null)
            {
                return HttpNotFound();
            }
            return View(diadiem);
             */

            return DeleteConfirmed(id);
        }

        //
        // POST: /DiaDiem/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DiaDiem diadiem = db.DiaDiems.Find(id);
            db.DiaDiems.Remove(diadiem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}