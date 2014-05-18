using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftRegMVC.ViewModels.Gift
{
    public class ViewEvent
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string Comment { get; set; }
    }
}