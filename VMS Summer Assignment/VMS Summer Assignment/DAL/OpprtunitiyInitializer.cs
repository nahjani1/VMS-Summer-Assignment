using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VMS_Summer_Assignment.Models;
using System.Data.Entity;



namespace VMS_Summer_Assignment.DAL
{
    public class OpprtunitiyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges
    {
        protected override void Seed(OppurtunityContext context)
        {
            var oppurtunity = new List<OppurtunityContext>
            {

            new Oppurtunities { Name = "Tuscany Rose Center", Center= "Car", Date =DateTime.Parse("08/19/18"  },
            new Oppurtunities { Name = "Happy's Hilltop Society", Center= "Tallahassee", Date = DateTime.Parse("08/22/18" },
             new Oppurtunities { Name = "Florida Inc", Center= "Jacksonville", Date = DateTime.Parse("08/14/18" },
             new Oppurtunities { Name = "Bolden & Friar", Center= "Miami", Date =  DateTime.Parse("08/30/18" },
            new Oppurtunities { Name = "Fleming Kids", Center= "Boca Raton", Date =  DateTime.Parse("08/10/18"  },
            new Oppurtunities { Name = "JSO", Center= "Ft. Lauderdale", Date =  DateTime.Parse("08/06/18" },
            };

            oppurtunity.ForEach(s => context.Oppurtunities.Add(s));
            context.SaveChanges();


            var matches = new List<Matches>
            {
            new Matches{ MatchName = "Tuscany Rose Center", MatchCenter= "Car", MatchDate =DateTime.Parse("08/19/18")},
            new Matches{ MatchName = "Happy's Hilltop Society", MatchCenter= "Tallahassee", MatchDate = DateTime.Parse("08/22/18") },
            new Matches{MatchName = "Florida Inc", MatchCenter= "Jacksonville", MatchDate = DateTime.Parse("08/14/18") },
            new Matches{ MatchName = "Bolden & Friar", MatchCenter= "Miami", MatchDate =  DateTime.Parse("08/30/18") },
            new Matches{ MatchName = "Fleming Kids", MatchCenter= "Boca Raton", MatchDate =  DateTime.Parse("08/10/18") },
            new Matches { MatchName = "JSO", MatchCenter= "Ft. Lauderdale", MatchDate =  DateTime.Parse("08/06/18") },
            };
            matches.ForEach(s => context.Matches.Add(s));
            context.SaveChanges();
            {
    }
}