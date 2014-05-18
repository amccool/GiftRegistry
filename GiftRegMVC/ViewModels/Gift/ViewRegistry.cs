using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftRegMVC.ViewModels.Gift
{
    public class ViewRegistry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string Content { get; set; }
        public ICollection<ViewItem> Items { get; set; }
    }

}