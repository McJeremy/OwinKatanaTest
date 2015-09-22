using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinConsoleHost
{
    using AppFunc = Func<Dictionary<string, object>, Task>;
    public class NonebaseMiddleware
    {
        private AppFunc _next;
        public NonebaseMiddleware(AppFunc next)
        {
            _next = next;
        }

        public Task Invoke(Dictionary<string, object> env)
        {
            Console.WriteLine("None base middleware.");
            return _next.Invoke(env);
        }
    }
}
