using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GiftRegMVC.Models.GiftRegistry
{
    public class Category
    {
        [DatabaseGenerated(  DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string sss { get; set; }

        //public int ItemID { get; set; }
        //public Item item { get; set; }
    }
}
