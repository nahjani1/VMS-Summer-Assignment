using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cocktail_Bar.Models
{
    public class Menu1
    {
        public int MenuID { get; set; }
        public string CocktailID{ get; set; }
       
        public virtual ICollection<Cocktail1> Cocktail1 { get; set; }
    }
}