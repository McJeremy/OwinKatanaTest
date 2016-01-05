using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulateIMiddleWare
{
    public class HelloMiddleware : IMiddleware
    {
        public IMiddleware Next
        {
            get;
            set;
        }
        public System.Threading.Tasks.Task Invoke(IContext context)
        {
            Console.WriteLine("This is Hello Middleware:");
            Console.WriteLine("You are visit app:{0},your accountid is {1}", context.AppID, context.AccountID);

            if (null == Next)
            {
                return null;            
            }
            return this.Next.Invoke(context);
        }
    }
}
