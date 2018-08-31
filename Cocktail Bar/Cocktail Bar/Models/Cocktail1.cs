using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cocktail_Bar.Models
{
    public class Cocktail1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public virtual ICollection<Menu> Menu { get; set; }
    }
}