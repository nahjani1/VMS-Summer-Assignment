using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VMS_Summer_Assignment.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<Status> Status { get; set; }
    }
}