using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Bridge
{
    class Plane : Unit
    {
        public Plane()
        {
            implementor = new PlaneMgmtSys();
        }
    }
}
