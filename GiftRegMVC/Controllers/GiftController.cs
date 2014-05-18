using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiftRegMVC.ViewModels.Gift;

namespace GiftRegMVC.Controllers
{
    public class GiftController : Controller
    {
        //
        // GET: /Gift/

        public ActionResult Index()
        {
            using (var context = new GiftRegMVC.Models.GiftRegistry.GiftRegistryContext())
            {
                // Will hit the database
                var person = context.People.Find(1);

                if (person == null)
                {
                    context.People.Add(new Models.GiftRegistry.Person()
                        {
                            Name = "billy",
                            Registry = new Models.GiftRegistry.Registry()
                            {
                                DateCreated = DateTime.UtcNow,
                                Title = "billy's list",
                                Content = "stuff"
                            }
                        });

                    context.SaveChanges();
                }

            }




            //get the viewmodel for teh main display
            var vm = new ViewModels.GiftMainViewModel();
            vm.myItems =  new List<ViewItem>();
            vm.pplImShoppingFor= new List<ViewPerson>();
            vm.msgs = new List<ViewMessage>();
            vm.events = new List<ViewEvent>();


            vm.myItems.Add(new ViewItem()
            {
                Category = new ViewCategory() { Title = "ccc" },
                Comment = "fff",
                Description = "fggg",
                Id = 1,
                 Currency = new ViewMoney() { Title = "$", Symbol="$" },
                  Price=5.5,
                Quantity = 3,
                Ranking = new ViewRank() { Title = "high", NumStars=3 },
                Store = new ViewStore() { Title = "amazon" },
                URL = "gggggggggggggg"
            });
            vm.myItems.Add(new ViewItem()
            {
                Category = new ViewCategory() { Title = "ccc" },
                Comment = "fff",
                Description = "fggg",
                Id = 2,
                Currency = new ViewMoney() { Title = "$", Symbol = "$" },
                Price = 5.5,
                Quantity = 3,
                Ranking = new ViewRank() { Title = "high", NumStars = 7 },
                Store = new ViewStore() { Title = "amazon" },
                URL = "gggggggggggggg"
            });
            vm.myItems.Add(new ViewItem()
            {
                Category = new ViewCategory() { Title = "ccc" },
                Comment = "fff",
                Description = "fggg",
                 Received = true,
                Id = 2,
                Currency = new ViewMoney() { Title = "$", Symbol = "$" },
                Price = 5.5,
                Quantity = 3,
                Ranking = new ViewRank() { Title = "high", NumStars = 7 },
                Store = new ViewStore() { Title = "amazon" },
                URL = "gggggggggggggg"
            });


            vm.pplImShoppingFor.Add(new ViewPerson()
            {
                Name = "bill"
            });
            vm.pplImShoppingFor.Add(new ViewPerson()
            {
                Name = "joe"
            });


            vm.msgs.Add(new ViewMessage()
                {
                    Comment = "ffff",
                    Description = "ggg"
                });
            vm.msgs.Add(new ViewMessage()
                {
                    Description = "gggg",
                    Comment = "ffff"
                });

            vm.events.Add(new ViewEvent()
                {
                    Comment = "comm",
                    Description = "desc"
                });



            return View(vm);
        }

        public ActionResult FakeItems()
        {
            using (var context = new GiftRegMVC.Models.GiftRegistry.GiftRegistryContext())
            {
                var person = context.People.Find(1);


                person.Registry = new Models.GiftRegistry.Registry()
                {
                    Content = "ffff",
                    DateCreated = DateTime.Now,
                    Title = "my regs",
                    Items = new List<GiftRegMVC.Models.GiftRegistry.Item>
                         {
                              new GiftRegMVC.Models.GiftRegistry.Item()
                              {
                                   Comment="ggg",
                                    Description="ffff",
                                     //Price = new Models.GiftRegistry.Money(){
                                        Quantity = 1,
                                         //Ranking = new Models.GiftRegistry.Rank()
                                          //Store = new Models.GiftRegistry.Store()
                                           URL = "iiiiiiii"
                                     
                              }
                         }

                };

                context.SaveChanges();
            }

            var myItems =  new List<ViewItem>();
            return View(myItems);
        }
        public ActionResult FakePeople()
        {
            var myItems = new List<ViewPerson>();
            return View(myItems);
        }
        public ActionResult FakeMessage()
        {
            var myItems = new List<ViewMessage>();
            return View(myItems);
        }
        public ActionResult FakeEvents()
        {
            var myItems = new List<ViewEvent>();
            return View(myItems);
        }


        //
        // GET: /Gift/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Gift/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Gift/Create

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
        // GET: /Gift/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Gift/Edit/5

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
        // GET: /Gift/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Gift/Delete/5

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
