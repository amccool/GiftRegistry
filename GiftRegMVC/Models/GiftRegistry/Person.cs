using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GiftRegMVC.Models.GiftRegistry
{
    public class Person
    {
                [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public Registry Registry { get; set; }
        public ICollection<Person> PeopleImShoppingFor { get; set; }
        public ICollection<Group> ActiveGroups { get; set; }
    }
}