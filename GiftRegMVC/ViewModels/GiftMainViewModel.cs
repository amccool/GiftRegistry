using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GiftRegMVC.ViewModels.Gift;


namespace GiftRegMVC.ViewModels
{
    public class GiftMainViewModel
    {
        public List<ViewItem> myItems { get; set; }
        public List<ViewPerson> pplImShoppingFor { get; set; }
        public List<ViewMessage> msgs { get; set; }
        public List<ViewEvent> events { get; set; }
    }
}