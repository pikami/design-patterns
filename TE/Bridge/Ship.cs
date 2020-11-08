using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Bridge
{
    class Ship : Unit
    {
        public Ship()
        {
            implementor = new ShipMgmtSys();
        }
    }
}
