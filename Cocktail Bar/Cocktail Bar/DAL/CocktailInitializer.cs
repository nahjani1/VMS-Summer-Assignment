using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Cocktail_Bar.Models;

namespace Cocktail_Bar.DAL
{
    public class CocktailInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges
    {
        protected override void Seed(OppurtunityContext context)
        {
            var oppurtunity = new List<OppurtunityContext>
            {

            new Cocktail { Name = "Tuscany Rose Center", Center= "Car", Date =DateTime.Parse("08/19/18"  },
            new Oppurtunities { Name = "Happy's Hilltop Society", Center= "Tallahassee", Date = DateTime.Parse("08/22/18" },
             new Oppurtunities { Name = "Florida Inc", Center= "Jacksonville", Date = DateTime.Parse("08/14/18" },
             new Oppurtunities { Name = "Bolden & Friar", Center= "Miami", Date =  DateTime.Parse("08/30/18" },
            new Oppurtunities { Name = "Fleming Kids", Center= "Boca Raton", Date =  DateTime.Parse("08/10/18"  },
            new Oppurtunities { Name = "JSO", Center= "Ft. Lauderdale", Date =  DateTime.Parse("08/06/18" },
            };

            oppurtunity.ForEach(s => context.Oppurtunities.Add(s));
            context.SaveChanges();

namespace System.Data.Entity
    {
        public class DropCreateDatabaseIfModelChanges
        {
        }
    }
}