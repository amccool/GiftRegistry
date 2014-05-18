using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace GiftRegMVC.ViewModels.Gift
{
    public class ViewCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public string sss { get; set; }

        //public int ItemID { get; set; }
        //public Item item { get; set; }
    }

    public class ViewCategories : SelectList
    {
        public ViewCategories(List<ViewCategory> categories, ViewCategory category) : base(categories, category)
        { }
    }

}
