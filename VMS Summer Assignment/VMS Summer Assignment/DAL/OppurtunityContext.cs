using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VMS_Summer_Assignment.Models;

namespace VMS_Summer_Assignment.DAL
{
    public class OppurtunityContext
    {
        public OppurtunityContext() : base("OppurtunityContext")
        {
        }

        public DbSet<Oppurtunities> Oppurtunities { get; set; }
        public DbSet<Matches> Matches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }   
}
