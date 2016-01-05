using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulateIMiddleWare
{
    class Program
    {
        static void Main(string[] args)
        {
            var use = new UseMain();
            use.Use<IMiddleware>(new HelloMiddleware());
            use.Use<AuthenticationMiddleware>();

            use.InvokeRequest();

            Console.Read();
        }
    }
}
