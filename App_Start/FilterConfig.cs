﻿using System.Web;
using System.Web.Mvc;

namespace aj618615_MIS4200_SD1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
