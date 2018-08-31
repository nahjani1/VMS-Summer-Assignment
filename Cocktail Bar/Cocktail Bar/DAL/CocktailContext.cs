 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cocktail_Bar.Models;

namespace Cocktail_Bar.DAL
{
    public class CocktailContext
    {
        public CocktailContext() : base("VolunteerContext")
        {
        }

        public DbSet<CocktailContext> VolunteerInfo { get; set; }
        public DbSet<Menu> Menu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            "";
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
}