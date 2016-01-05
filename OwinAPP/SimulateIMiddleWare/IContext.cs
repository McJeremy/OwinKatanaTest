using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulateIMiddleWare
{
    public interface IContext
    {
        string AppID
        {
            get;
            set;
        }

        string AccountID
        {
            get;
            set;
        }
    }
}
