using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinAPP
{
    public class NonebaseMiddleware : OwinMiddleware
    {
        public NonebaseMiddleware(OwinMiddleware next) : base(next)
        { }

        public override Task Invoke(IOwinContext context)
        {
            context.Response.Write(("22 NonebaseMiddleware"));
            return Next.Invoke(context);
        }
    }
    //using AppFunc = Func<Dictionary<string, object>, Task>;
    //public class NonebaseMiddleware
    //{
    //    private AppFunc _next;
    //    public NonebaseMiddleware(AppFunc next)
    //    {
    //        if (next == null)
    //        {
    //            throw new ArgumentNullException("next");
    //        }

    //        _next = next;
    //    }

    //    public Task Invoke(Dictionary<string, object> env)
    //    {
    //        IOwinContext c = new OwinContext(env);
    //        c.Response.Write("None base middleware.");
    //        return _next(env);
    //    }
    //}
}
