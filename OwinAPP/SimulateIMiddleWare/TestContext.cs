using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulateIMiddleWare
{
    public class TestContext: IContext
    {
        public string AppID
        {
            get;
            set;
        }

        public string AccountID
        {
            get;
            set;
        }
    }
}
