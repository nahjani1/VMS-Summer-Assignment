﻿using System.Web;
using System.Web.Mvc;

namespace Cocktail_Bar
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
