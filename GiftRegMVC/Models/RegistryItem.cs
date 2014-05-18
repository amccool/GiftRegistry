using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftRegMVC.Models
{
    public class RegistryItem
    {
        public int Id;
        public string Description;
        public Category Category;
        public Money Price;
        public Store Store;
        public Rank Ranking;
        public int Quantity;

        public Uri URL;
        public string Comment;
    }
}