using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulateIMiddleWare
{
    public class AuthenticationMiddleware : IMiddleware
    {
        public IMiddleware Next
        {
            get;
            set;
        }
        public System.Threading.Tasks.Task Invoke(IContext context)
        {
            Console.WriteLine("This is Authentication Middleware:");
            Console.WriteLine("You are authriszed");

            if (null == Next)
            {
                return null;
            }
            //如果没有认证通过，跳转到其它地方。
            return this.Next.Invoke(context);
        }
    }
}
