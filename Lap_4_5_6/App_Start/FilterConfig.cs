﻿using System.Web;
using System.Web.Mvc;

namespace Lap_4_5_6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}