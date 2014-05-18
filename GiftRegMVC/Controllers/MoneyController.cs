using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiftRegMVC.Models.GiftRegistry;

namespace GiftRegMVC.Controllers
{ 
    public class MoneyController : Controller
    {
        private GiftRegistryContext db = new GiftRegistryContext();

        //
        // GET: /Money/

        public ViewResult Index()
        {
            return View(db.Moneies.ToList());
        }

        //
        // GET: /Money/Details/5

        public ViewResult Details(int id)
        {
            Money money = db.Moneies.Find(id);
            return View(money);
        }

        //
        // GET: /Money/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Money/Create

        [HttpPost]
        public ActionResult Create(Money money)
        {
            if (ModelState.IsValid)
            {
                db.Moneies.Add(money);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(money);
        }
        
        //
        // GET: /Money/Edit/5
 
        public ActionResult Edit(int id)
        {
            Money money = db.Moneies.Find(id);
            return View(money);
        }

        //
        // POST: /Money/Edit/5

        [HttpPost]
        public ActionResult Edit(Money money)
        {
            if (ModelState.IsValid)
            {
                db.Entry(money).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(money);
        }

        //
        // GET: /Money/Delete/5
 
        public ActionResult Delete(int id)
        {
            Money money = db.Moneies.Find(id);
            return View(money);
        }

        //
        // POST: /Money/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Money money = db.Moneies.Find(id);
            db.Moneies.Remove(money);
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