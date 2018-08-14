using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VMS_Summer_Assignment.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace VMS_Summer_Assignment.DAL
{
    public class VolunteerContext : DbContext
    {
        public VolunteerContext() : base("VolunteerContext")
        {
        }

        public DbSet<VolunteerInfo> VolunteerInfo { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
   
