using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GiftRegMVC.Models.GiftRegistry
{
    public class GiftRegistryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Money> Moneies { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Registry> Registries { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Store> Stores { get; set; }

    }
}