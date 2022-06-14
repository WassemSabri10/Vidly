using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Vidly
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            /*
              Jason object are named using Pascal notation.
              So the first letter of every word is uppercase but in javascript we use Camal ntaion.
              So the first letter of the first word should be lowercase and the first letter of every word after should
              be uppercase.
              So with the current situation if we consume these objects in javascript our code is going to get a little
              bit ugly.
              So let me show you how to configure web API to return JSON object using Caml notation in solution.
            */

            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Newtonsoft.Json.Formatting.Indented;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

