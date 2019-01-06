﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _4_FirstApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );

            //routes.MapRoute(
            //    "MovieByRealeas",
            //    "movie/release/{year}/{month}",
            //    new { controller = "Movie", action = "ByReleaseDate" },
            //    new { year = @"\d{4}", month = @"\d{2}" }
            //    );
        }
    }
}
