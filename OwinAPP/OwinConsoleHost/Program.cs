using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (Microsoft.Owin.Hosting.WebApp.Start<Startup1>("http://localhost:10334"))
            //{
            //    Console.WriteLine("press any key to exit");
            //    Console.Read();
            //}

            //宿主webapi
            using (Microsoft.Owin.Hosting.WebApp.Start<WebApiTest.Startup>("http://localhost:10334"))
            {
                Console.WriteLine("press any key to exit");
                Console.Read();
            }
        }
    }
}
