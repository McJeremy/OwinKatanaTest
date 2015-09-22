using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Collections.Generic;
using System.IO;
using System.Text;

[assembly: OwinStartup(typeof(OwinConsoleHost.Startup1))]

namespace OwinConsoleHost
{
    using AppFunc = Func<Dictionary<string, object>, Task>;
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            //  app.UseWelcomePage("/");
            //app.Use(new Func<AppFunc, AppFunc>(
            //    next => (
            //        env =>
            //        {
            //            string strText = "原始方式的Owin";
            //            var response = env["owin.ResponseBody"] as Stream;
            //            var responseHeaders = env["owin.ResponseHeader"] as Dictionary<string, string[]>;
            //            responseHeaders.Add("content-type", "text-plain");
            //            return response.WriteAsync(Encoding.UTF8.GetBytes(strText), 0, strText.Length);
            //        }
            //    )));

            app.Use<HelloWorldMiddleware>();
            
            app.Use<NonebaseMiddleware>();

            app.Use((context, next) => {
                TextWriter output = context.Get<TextWriter>("host.TraceOutput");
                return next().ContinueWith(result =>
                {
                    output.WriteLine("Scheme {0} : Method {1} : Path {2} : MS {3}",
                    context.Request.Scheme, context.Request.Method, context.Request.Path, getTime());
                });
            });

            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            app.Run(context => {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello Owin from selfhost!");
            });
        }

        string getTime()
        {
            return DateTime.Now.Millisecond.ToString();
        }
    }
}
