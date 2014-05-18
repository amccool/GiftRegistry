using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GiftRegMVC.Models.GiftRegistry
{
    public class GiftRegistryChangedInitializer :
        DropCreateDatabaseIfModelChanges<GiftRegistryContext>
    {
        protected override void Seed(GiftRegistryContext context)
        {
            var ranks = new List<Rank>
            {
                new Rank{ Title="big"},
                new Rank{ Title="small"}
            };

            var monies = new List<Money>
            {
                new Money{ Title="dollar"}
            };

            var cats = new List<Category>
            {
                new Category{ Title="tools"},
                new Category{ Title="toys"},
                new Category{ Title="games"}
            };

            ranks.ForEach(d => context.Ranks.Add(d));
            monies.ForEach(d => context.Moneies.Add(d));
            cats.ForEach(d => context.Categories.Add(d));


            base.Seed(context);
        }
    }


    public class GiftRegistryAlwaysInitializer :
        DropCreateDatabaseAlways<GiftRegistryContext>
    {   
        protected override void Seed(GiftRegistryContext context)
        {
            var ranks = new List<Rank>
            {
                new Rank{ 
                     Id=1,
                    Title="big"},
                new Rank{ 
                     Id=2,
                    Title="small"}
            };

            var monies = new List<Money>
            {
                new Money{ 
                     Id=1,
                    Title="dollar"}
            };

            var cats = new List<Category>
            {
                new Category{ 
                     Id =1,
                    Title="tools"},
                new Category{
                     Id=2,
                    Title="toys"},
                new Category{ 
                     Id =3,
                    Title="games"}
            };


            ///sample data
            ///
            var grps = new List<Group>
            {
                new Group
                {
                     Administrator=new Person{
                          Name="adminforthegroup"
                     },
                      Title="simplegroup"
                },
                new Group
                {
                    Title="anothergroup"
                }
            };


            var ppl = new List<Person>
            {
                new Person{ 
                    Name="tom",
                      
                },
                new Person 
                {
                    Name="dick"
                },
                new Person 
                {
                    Name="harry"
                }
            };














            ranks.ForEach(d => context.Ranks.Add(d));
            monies.ForEach(d => context.Moneies.Add(d));
            cats.ForEach(d => context.Categories.Add(d));
            grps.ForEach(d => context.Groups.Add(d));
            ppl.ForEach(d => context.People.Add(d));

            base.Seed(context);
        }
    }
}