using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinAPP
{
    public class AppOptionsMiddleware : OwinMiddleware
    {
        public AppOptionsMiddleware(OwinMiddleware next) :base(next)
        {            
        }

        public override Task Invoke(IOwinContext context)
        {
            context.Environment.Add("app_name", "sapi");
            return Next.Invoke(context);
        }
    }
}
