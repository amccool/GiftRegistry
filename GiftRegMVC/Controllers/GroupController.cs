using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiftRegMVC.Models;
using GiftRegMVC.Models.GiftRegistry;

namespace GiftRegMVC.Controllers
{ 
    public class GroupController : Controller
    {
        private GiftRegistryContext db = new GiftRegistryContext();

        //
        // GET: /Group/

        public ViewResult Index()
        {
            return View(db.Groups.ToList());
        }

        //
        // GET: /Group/Details/5

        public ViewResult Details(int id)
        {
            Group group = db.Groups.Find(id);
            return View(group);
        }

        //
        // GET: /Group/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Group/Create

        [HttpPost]
        public ActionResult Create(Group group)
        {
            if (ModelState.IsValid)
            {
                db.Groups.Add(group);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(group);
        }
        
        //
        // GET: /Group/Edit/5
 
        public ActionResult Edit(int id)
        {
            Group group = db.Groups.Find(id);
            return View(group);
        }

        //
        // POST: /Group/Edit/5

        [HttpPost]
        public ActionResult Edit(Group group)
        {
            if (ModelState.IsValid)
            {
                db.Entry(group).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(group);
        }

        //
        // GET: /Group/Delete/5
 
        public ActionResult Delete(int id)
        {
            Group group = db.Groups.Find(id);
            return View(group);
        }

        //
        // POST: /Group/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Group group = db.Groups.Find(id);
            db.Groups.Remove(group);
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