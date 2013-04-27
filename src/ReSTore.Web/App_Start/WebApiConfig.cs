﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ReSTore.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "CategoriesApi",
                routeTemplate: "api/areas/{areaId}/categories/{id}",
                defaults: new { controller = "categories", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "ProductsApi",
                routeTemplate: "api/areas/{areaId}/categories/{categoryId}/products/{id}",
                defaults: new { controller = "products", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "CommandsApi",
                routeTemplate: "api/commands/{action}/{commandId}",
                defaults: new { controller="commands", commandId = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}