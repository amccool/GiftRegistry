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
    public class StoreController : Controller
    {
        private GiftRegistryContext db = new GiftRegistryContext();

        //
        // GET: /Store/

        public ViewResult Index()
        {
            return View(db.Stores.ToList());
        }

        //
        // GET: /Store/Details/5

        public ViewResult Details(int id)
        {
            Store store = db.Stores.Find(id);
            return View(store);
        }

        //
        // GET: /Store/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Store/Create

        [HttpPost]
        public ActionResult Create(Store store)
        {
            if (ModelState.IsValid)
            {
                db.Stores.Add(store);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(store);
        }
        
        //
        // GET: /Store/Edit/5
 
        public ActionResult Edit(int id)
        {
            Store store = db.Stores.Find(id);
            return View(store);
        }

        //
        // POST: /Store/Edit/5

        [HttpPost]
        public ActionResult Edit(Store store)
        {
            if (ModelState.IsValid)
            {
                db.Entry(store).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(store);
        }

        //
        // GET: /Store/Delete/5
 
        public ActionResult Delete(int id)
        {
            Store store = db.Stores.Find(id);
            return View(store);
        }

        //
        // POST: /Store/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Store store = db.Stores.Find(id);
            db.Stores.Remove(store);
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