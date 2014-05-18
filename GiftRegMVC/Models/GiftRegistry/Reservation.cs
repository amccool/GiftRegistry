using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GiftRegMVC.Models.GiftRegistry
{
    public class Reservation
    {
                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int PersonId { get; set; }
        public int ItemId { get; set; }
        public bool Purchased { get; set; }
        public bool Reserved { get; set; }
        public int quantity { get; set; }
    }
}