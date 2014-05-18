using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GiftRegMVC.ViewModels.Gift
{
    public class ViewItem
    {
        public int Id { get; set; }
        public string Description { get; set; }

        //public int? CategoryId { get; set; }
        public ViewCategory Category { get; set; }
        
        public virtual ViewMoney Currency { get; set; }
        public virtual double Price { get; set; }
        public virtual ViewStore Store { get; set; }
        public virtual ViewRank Ranking { get; set; }
        public int Quantity { get; set; }
        public bool Received { get; set; }

        public string URL { get; set; }
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }

        //public ViewCategories Categories { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Rankings { get; set; }
    }
}