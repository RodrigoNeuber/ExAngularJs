using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //var cors = new EnableCorsAttribute("*", "*", "*"); //considere que aqui que qualquer site poderá enviar requisições ajax
            var cors = new EnableCorsAttribute("http://localhost:51158", "*", "*");
            config.EnableCors(cors);

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
