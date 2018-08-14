using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VMS_Summer_Assignment.Models;

namespace VMS_Summer_Assignment.DAL
{
    public class VolunteerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges
    {
        protected override void Seed(VolunteerContext context)
        {
            var volunteers = new List<VolunteerInfo>
            {

            new VolunteerInfo { FirstName = "Alexander", LastName = "Car" },
            new VolunteerInfo { FirstName = "Steph", LastName = "Phillips"},
            new VolunteerInfo { FirstName = "Chino", LastName = "Anand" },
            new VolunteerInfo { FirstName = "Siwan", LastName = "Hoon"},
            new VolunteerInfo { FirstName = "Mike", LastName = "Chi"},
            new VolunteerInfo { FirstName = "Andrea", LastName = "Williams"},
            new VolunteerInfo { FirstName = "Lauren", LastName = "Diaz"},
            new VolunteerInfo{ FirstName = "Nyla", LastName = "" }
            };

            volunteers.ForEach(s => context.VolunteerInfo.Add(s));
            context.SaveChanges();

            var status = new List<Status>
            {
            new Status{ApprovedID=1,PendingApprovalID=100,DisapprovedID=1001,InactiveID=2001, AllID= 3001},
            new Status{ApprovedID=2,PendingApprovalID=101,DisapprovedID=1002, InactiveID=2002, AllID= 3002},
            new Status{ApprovedID=3,PendingApprovalID=102,DisapprovedID=1003, InactiveID=2003, AllID= 3003},
            new Status{ApprovedID=4,PendingApprovalID=103,DisapprovedID=1004, InactiveID=2004, AllID= 3004},
            new Status{ApprovedID=5,PendingApprovalID=104,DisapprovedID=1005, InactiveID=2005, AllID= 3005},
            new Status{ApprovedID=6,PendingApprovalID=105,DisapprovedID=1006, InactiveID=2006, AllID= 3006},
            new Status{ApprovedID=7,PendingApprovalID=106,DisapprovedID=1007, InactiveID=2007, AllID= 3007},
            new Status{ApprovedID=8,PendingApprovalID=107,DisapprovedID=1008, InactiveID=2008, AllID= 3008},

            };
            status.ForEach(s => context.Status.Add(s));
            context.SaveChanges();
        }
    }
}    

