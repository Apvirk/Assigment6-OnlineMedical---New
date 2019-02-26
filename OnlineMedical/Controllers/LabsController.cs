using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMedical;

namespace OnlineMedical.Controllers
{
    public class LabsController : Controller
    {
        private MedicalEntities db = new MedicalEntities();

        // GET: Labs
        public ActionResult Index()
        {
            var labs = db.Labs.Include(l => l.Doctor).Include(l => l.Patient);
            return View(labs.ToList());
        }

        // GET: Labs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lab lab = db.Labs.Find(id);
            if (lab == null)
            {
                return HttpNotFound();
            }
            return View(lab);
        }

        // GET: Labs/Create
        public ActionResult Create()
        {
            ViewBag.Doctor_ID = new SelectList(db.Doctors, "Doctor_ID", "Doctor_Name");
            ViewBag.Patient_ID = new SelectList(db.Patients, "Patient_ID", "Patient_Name");
            return View();
        }

        // POST: Labs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Lab_ID,Doctor_ID,Lab_Date,Patient_ID,Invoice_Amount,Lab_Procedure")] Lab lab)
        {
            if (ModelState.IsValid)
            {
                db.Labs.Add(lab);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Doctor_ID = new SelectList(db.Doctors, "Doctor_ID", "Doctor_Name", lab.Doctor_ID);
            ViewBag.Patient_ID = new SelectList(db.Patients, "Patient_ID", "Patient_Name", lab.Patient_ID);
            return View(lab);
        }

        // GET: Labs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lab lab = db.Labs.Find(id);
            if (lab == null)
            {
                return HttpNotFound();
            }
            ViewBag.Doctor_ID = new SelectList(db.Doctors, "Doctor_ID", "Doctor_Name", lab.Doctor_ID);
            ViewBag.Patient_ID = new SelectList(db.Patients, "Patient_ID", "Patient_Name", lab.Patient_ID);
            return View(lab);
        }

        // POST: Labs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Lab_ID,Doctor_ID,Lab_Date,Patient_ID,Invoice_Amount,Lab_Procedure")] Lab lab)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lab).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Doctor_ID = new SelectList(db.Doctors, "Doctor_ID", "Doctor_Name", lab.Doctor_ID);
            ViewBag.Patient_ID = new SelectList(db.Patients, "Patient_ID", "Patient_Name", lab.Patient_ID);
            return View(lab);
        }

        // GET: Labs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lab lab = db.Labs.Find(id);
            if (lab == null)
            {
                return HttpNotFound();
            }
            return View(lab);
        }

        // POST: Labs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Lab lab = db.Labs.Find(id);
            db.Labs.Remove(lab);
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
