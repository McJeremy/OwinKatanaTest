using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.IO;

[assembly: OwinStartup(typeof(OwinAPP.Startup1))]

namespace OwinAPP
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            //app.Use((context, next) => {
            //    TextWriter output = context.Get<TextWriter>("host.TraceOutput");
            //    return next().ContinueWith(result =>
            //    {
            //        output.WriteLine("Scheme {0} : Method {1} : Path {2} : MS {3}",
            //        context.Request.Scheme, context.Request.Method, context.Request.Path, getTime());
            //    });
            //});

            app.Use<AppOptionsMiddleware>();

            app.Use<HelloWorldMiddleware>();

            app.Use<NonebaseMiddleware>();

            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            app.Run(context => {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello Owin!");
            });
        }

        string getTime()
        {
            return DateTime.Now.Millisecond.ToString();
        }
    }
}
