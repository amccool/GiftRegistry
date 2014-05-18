using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GiftRegMVC.Models.GiftRegistry;
using System.ComponentModel.DataAnnotations;

namespace GiftRegMVC.Models
{
    public class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public Person Administrator { get; set; }
    }
}