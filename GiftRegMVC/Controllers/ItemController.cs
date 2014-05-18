using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using GiftRegMVC.Models.GiftRegistry;
using GiftRegMVC.ViewModels.Gift;

namespace GiftRegMVC.Controllers
{ 
    public class ItemController : Controller
    {
        private GiftRegistryContext db = new GiftRegistryContext();

        //
        // GET: /Item/

        public ViewResult Index()
        {
            return View(db.Items.ToList());
        }

        //
        // GET: /Item/Details/5

        public ViewResult Details(int id)
        {
            Item item = db.Items.Find(id);
            return View(item);
        }

        public List<Category> GetAllCategories()
        {
            return db.Categories.ToList();
        } 
        //

        // GET: /Item/Create

        public ActionResult Create()
        {
            GiftRegMVC.ViewModels.Gift.ViewItem m = new ViewModels.Gift.ViewItem()
            {
                Comment = "sdfgsfsfsf",
                Description = "sfsfsfsfsfsf",
                Currency = new ViewModels.Gift.ViewMoney() { Title = "dollar", Symbol = "$" },
                Price = 100.65,
                Quantity = 2,
                Ranking = new ViewModels.Gift.ViewRank() { Title = "want" },
                Store = new ViewModels.Gift.ViewStore() { Title = "amazon" },
                URL = "xxxxxxxxxxxxxxxxxxxxxx"
            };
            return View(m);
        } 

        //
        // POST: /Item/Create

        [HttpPost]
        public ActionResult Create(ViewItem item)
        {
            if (ModelState.IsValid)
            {
                //convert the viewmodel into model
                var dbitem = new Item();
                //db.Categories = item.Categories;
                //db.Groups = item.g
                dbitem.Comment = item.Comment;
                dbitem.Description = item.Description;
                //dbitem.Price = item.Price;
                dbitem.Quantity = item.Quantity;
                //dbitem.Ranking = item.Ranking;
                
                //dbitem.Store = item.Store;
                dbitem.URL = item.URL;

                db.Items.Add(dbitem);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(item);
        }
        
        //
        // GET: /Item/Edit/5
 
        public ActionResult Edit(int id)
        {
            //Item item = db.Items.Find(id);
            //convert it to a viewmodel
            GiftRegMVC.ViewModels.Gift.ViewItem m = new ViewModels.Gift.ViewItem()
            {
                //Categories = new ViewModels.Gift.ViewCategories(
                //    new List<ViewModels.Gift.ViewCategory>()
                //    {
                //        new ViewModels.Gift.ViewCategory() { Title = "fffff", Id=1 }, 
                //        new ViewModels.Gift.ViewCategory() { Title = "gggggg", Id=2 }
                //    },
                //    new ViewModels.Gift.ViewCategory() { Title = "fffff", Id=1 }),

                     Category = new ViewModels.Gift.ViewCategory() { Title = "fffff", Id=1 },

                Comment = "sdfgsfsfsf",
                Description = "sfsfsfsfsfsf",
                 Currency = new ViewModels.Gift.ViewMoney() { Title = "dollar", Symbol="$" },
                  Price=6.78,
                Quantity = 2,
                Ranking = new ViewModels.Gift.ViewRank() { Title = "want" },
                Store = new ViewModels.Gift.ViewStore() { Title = "amazon" },
                URL = "xxxxxxxxxxxxxxxxxxxxxx"
            };






            var categories = new List<ViewModels.Gift.ViewCategory>()
                    {
                        new ViewModels.Gift.ViewCategory() { Title = "fffff", Id=1 }, 
                        new ViewModels.Gift.ViewCategory() { Title = "gggggg", Id=2 }
                    };
            List<SelectListItem> modCats = new List<SelectListItem>();
            foreach (var cat in categories)
            {
                modCats.Add(new SelectListItem() { Text = cat.Title, Value = cat.Id.ToString(), Selected=false  });
            }
            m.Categories = modCats;

            var rankings = new List<ViewModels.Gift.ViewRank>()
                    {
                         new ViewModels.Gift.ViewRank(){ Id=1, NumStars=1, Title="x"},
                         new ViewModels.Gift.ViewRank(){ Id=2, NumStars=2, Title="xx"},
                         new ViewModels.Gift.ViewRank(){ Id=3, NumStars=3, Title="xxx"},
                         new ViewModels.Gift.ViewRank(){ Id=4, NumStars=4, Title="xxxx"},
                         new ViewModels.Gift.ViewRank(){ Id=5, NumStars=5, Title="xxxxx"},
                    };
            List<SelectListItem> ranks = new List<SelectListItem>();
            foreach (var rank in rankings)
            {
                ranks.Add(new SelectListItem() { Text = rank.Title, Value = rank.Id.ToString(), Selected = false });
            }
            m.Rankings = ranks;





            return View(m);
        }

        //
        // POST: /Item/Edit/5

        [HttpPost]
        public ActionResult Edit(GiftRegMVC.ViewModels.Gift.ViewItem item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }


        //
        // GET: /Item/Receive/5

        public ActionResult Receive(int id)
        {
            Item item = db.Items.Find(id);
            //return View(item);
            return RedirectToAction("Index");

        }





        //
        // GET: /Item/Delete/5
 
        public ActionResult Delete(int id)
        {
            Item item = db.Items.Find(id);
            return View(item);
        }

        //
        // POST: /Item/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
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