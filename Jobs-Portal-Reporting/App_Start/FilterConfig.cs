﻿using System.Web;
using System.Web.Mvc;

namespace Jobs_Portal_Reporting
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
