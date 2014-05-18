using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GiftRegMVC.Models.GiftRegistry
{
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }

        public int? CategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        
        public virtual Money Price { get; set; }
        public virtual Store Store { get; set; }
        public virtual Rank Ranking { get; set; }
        public int Quantity { get; set; }

        public string URL { get; set; }
        public string Comment { get; set; }
    }
}