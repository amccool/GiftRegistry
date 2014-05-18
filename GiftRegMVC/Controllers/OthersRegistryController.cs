using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftRegMVC.Controllers
{
    public class OthersRegistryController : Controller
    {
        //
        // GET: /OthersRegistry/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /OthersRegistry/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /OthersRegistry/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /OthersRegistry/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /OthersRegistry/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /OthersRegistry/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OthersRegistry/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /OthersRegistry/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
