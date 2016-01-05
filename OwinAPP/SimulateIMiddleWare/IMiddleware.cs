using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateIMiddleWare
{
    public interface IMiddleware
    {
        IMiddleware Next
        {
            set;
        }
        
        Task Invoke(IContext context);        
    }
}
