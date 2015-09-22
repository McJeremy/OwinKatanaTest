using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinAPP
{
    public class HelloWorldMiddleware : OwinMiddleware
    {
        public HelloWorldMiddleware(OwinMiddleware next) :base(next)
        {            
        }

        public override Task Invoke(IOwinContext context)
        {
            context.Response.Write("In HelloWorldMiddleware get APPNAME:"+context.Environment["app_name"]+"\r\n");
            context.Response.Write(DateTime.Now.ToString("111 yyyy-MM-dd HH:ss"));
            return Next.Invoke(context);
        }
    }
}
