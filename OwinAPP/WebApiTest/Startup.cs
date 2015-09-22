﻿using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

[assembly:OwinStartup(typeof(WebApiTest.Startup))]

namespace WebApiTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "webapi", 
                routeTemplate: "api/{controller}/{id}",
                defaults:new{id=RouteParameter.Optional });

            app.UseWebApi(config);

            //app.Use((c, next) => { return Task.Delay(1000); });


        }
    }
}
