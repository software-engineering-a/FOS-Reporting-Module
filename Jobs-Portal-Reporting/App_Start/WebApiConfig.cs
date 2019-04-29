﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace Jobs_Portal_Reporting.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SupportedMediaTypes
               .Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute(
                name: "ControllersApi",
                 routeTemplate: "api/{controller}/{action}/{id}",
                    defaults: new { controller = "Reporting", action = "Get", id = RouteParameter.Optional }
            );
        }
    }
}