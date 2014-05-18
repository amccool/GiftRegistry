using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiftRegMVC.Models;

namespace GiftRegMVC.Controllers
{
    public class MyRegistryController : Controller
    {
        static List<RegistryItem> registryItems = new List<RegistryItem>();
        //
        // GET: /MyRegistry/

        public ActionResult Index()
        {
            return View(registryItems);
        }

        //
        // GET: /MyRegistry/Details/5

        public ActionResult Details(int id)
        {
            var r = registryItems.Where(o => o.Id == id);
            return View(r);
        }

        //
        // GET: /MyRegistry/Create

        public ActionResult Create(RegistryItem r)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", r);
            }

            registryItems.Add(r);

            return RedirectToAction("Index");
        } 

        //
        // POST: /MyRegistry/Create

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
        // GET: /MyRegistry/Edit/5
 
        public ActionResult Edit(int id)
        {
            RegistryItem r = new RegistryItem();
            foreach (RegistryItem ri in registryItems)
            {
                if (ri.Id == id)
                {
                    r.Description = ri.Description;
                    r.Category = ri.Category;
                    r.Comment = ri.Comment;
                    r.Id = ri.Id;
                    r.Price = ri.Price;
                    r.Quantity = ri.Quantity;
                    r.Ranking = ri.Ranking;
                    r.Store = ri.Store;
                    r.URL = ri.URL;

                }
            }
            return View(r);
        }

        //
        // POST: /MyRegistry/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var r = registryItems.Where(o => o.Id == id);
                if (!ModelState.IsValid)
                {
                    return View("Edit", r);
                }

                foreach (var ri in registryItems)
                {
                    if (ri.Id == id)
                    {
                        //pn.Name = p.Name;
                        //pn.Age = p.Age;
                        //pn.Id = p.Id;
                        //pn.Phone = p.Phone;
                        //pn.Email = p.Email;
                    }
                }
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /MyRegistry/Delete/5
 
        public ActionResult Delete(int id)
        {
            RegistryItem r = new RegistryItem();
            foreach (RegistryItem ri in registryItems)
            {
                if (ri.Id == id)
                {
                    r.Description = ri.Description;
                    r.Category = ri.Category;
                    r.Comment = ri.Comment;
                    r.Id = ri.Id;
                    r.Price = ri.Price;
                    r.Quantity = ri.Quantity;
                    r.Ranking = ri.Ranking;
                    r.Store = ri.Store;
                    r.URL = ri.URL;

                }
            }
            return View(r);
        }

        //
        // POST: /MyRegistry/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                foreach (var r in registryItems)
                {
                    if (r.Id == id)
                    {
                        registryItems.Remove(r);
                        break;
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
