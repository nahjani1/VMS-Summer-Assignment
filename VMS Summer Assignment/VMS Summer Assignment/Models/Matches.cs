using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VMS_Summer_Assignment.Models
{
    public class Matches
    {
        public int ID { get; set; }
        public string MatchName { get; set; }
        public string MatchCenter { get; set; }
        public DateTime MatchDate { get; set; }

        public virtual ICollection<Oppurtunities> Oppurtunities { get; set; }
    }
}