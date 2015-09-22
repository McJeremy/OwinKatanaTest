using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinConsoleHost
{
    public class HelloWorldMiddleware : OwinMiddleware
    {
        public HelloWorldMiddleware(OwinMiddleware next) :base(next)
        { }

        public override Task Invoke(IOwinContext context)
        {
            context.Response.Write(DateTime.Now.ToString("yyyy-MM-dd HH:ss"));
            return Next.Invoke(context);
        }
    }
}
