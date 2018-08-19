using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VMS_Summer_Assignment.Models
{
    public class Oppurtunities
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Center{ get; set; }
        public DateTime Date{ get; set; }

        public virtual ICollection<Matches> Matches { get; set; }
    }
}