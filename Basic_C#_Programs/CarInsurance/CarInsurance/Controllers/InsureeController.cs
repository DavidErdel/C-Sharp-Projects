using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;


namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        
        // GET: Insuree
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        
        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,/*Quote*/")] Insuree userEntry)
        {
            if (ModelState.IsValid)
            {
                Insuree insuree = new Insuree();
                insuree.FirstName = userEntry.FirstName;
                insuree.LastName = userEntry.LastName;
                insuree.CarYear = userEntry.CarYear;
                insuree.CarMake = userEntry.CarMake;
                insuree.CarModel = userEntry.CarModel;
                insuree.SpeedingTickets = userEntry.SpeedingTickets;
                insuree.DUI = userEntry.DUI;
                insuree.CoverageType = userEntry.CoverageType;
                insuree.DateofBirth = userEntry.DateofBirth;
                insuree.EmailAddress = userEntry.EmailAddress;
                insuree.Quote = userEntry.Quote;

                //This block will calculate the user's age//
                DateTime dateOfBirth = DateTime.Today;

                var today = DateTime.Today;
                int userAge = today.Year - userEntry.DateofBirth.Year;

                //This begins the calculation of the quote//
                decimal baseQuote = 50M;

                //This block adds an amount to the quote based on the user's age//
                if (userAge <= 18)
                {
                    insuree.Quote = baseQuote + 100;
                }
                else if (userAge >= 19 && userAge <= 25)
                {
                    insuree.Quote = baseQuote + 50;
                }
                else insuree.Quote = baseQuote + 25;

                //This block adds to the quote based on the year of the user's car//
                if (userEntry.CarYear < 2000)
                {
                    insuree.Quote = insuree.Quote + 25;
                }
                else if (userEntry.CarYear > 2015)
                {
                    insuree.Quote = insuree.Quote + 25;
                }

                //This block adds to the quote based on the make and model of the user's car//
                if (userEntry.CarMake == "Porsche")
                {
                    insuree.Quote = insuree.Quote + 25;
                }

                if (userEntry.CarMake == "Porshe" && (userEntry.CarModel == "911 Carrera"))
                {
                    insuree.Quote = insuree.Quote + 25;
                }

                //This block adds to the quote based on whether the user has had any speeding tickets//
                int ticketPenalty;

                if (userEntry.SpeedingTickets > 0)
                {
                    ticketPenalty = userEntry.SpeedingTickets * 10;
                    insuree.Quote = insuree.Quote + ticketPenalty;
                }

                //This block adds to the quote based on whether the user has had any DUIs//
                decimal duiPenalty;

                if (userEntry.DUI == true)
                {
                    duiPenalty = (insuree.Quote / 100 * 25);
                    insuree.Quote = insuree.Quote + duiPenalty;
                }

                //This block adds to the quote based on whether the user has selected full coverage//
                decimal fullCoverageCharge;

                if (userEntry.CoverageType == true)
                {
                    fullCoverageCharge = (insuree.Quote / 100 * 50);
                    insuree.Quote = insuree.Quote + fullCoverageCharge;
                }

                ViewBag.FinalQuote = insuree.Quote;


                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("GetQuote");
            }

            return View(userEntry);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
