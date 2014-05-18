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
    public class RegistryController : Controller
    {
        private GiftRegistryContext db = new GiftRegistryContext();

        //
        // GET: /Registry/

        public ViewResult Index()
        {
            return View(db.Registries.ToList());
        }

        //
        // GET: /Registry/Details/5

        public ViewResult Details(int id)
        {
            Registry registry = db.Registries.Find(id);
            return View(registry);
        }

        //
        // GET: /Registry/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Registry/Create

        [HttpPost]
        public ActionResult Create(Registry registry)
        {
            if (ModelState.IsValid)
            {
                db.Registries.Add(registry);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(registry);
        }
        
        //
        // GET: /Registry/Edit/5
 
        public ActionResult Edit(int id)
        {
            Registry registry = db.Registries.Find(id);
            return View(registry);
        }

        //
        // POST: /Registry/Edit/5

        [HttpPost]
        public ActionResult Edit(Registry registry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registry);
        }

        //
        // GET: /Registry/Delete/5
 
        public ActionResult Delete(int id)
        {
            Registry registry = db.Registries.Find(id);
            return View(registry);
        }

        //
        // POST: /Registry/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Registry registry = db.Registries.Find(id);
            db.Registries.Remove(registry);
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