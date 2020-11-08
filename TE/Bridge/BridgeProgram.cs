using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Bridge
{
    class BridgeProgram // Program is client here        
    { // not exactly like example
        public static void BridgeMain()
        {
            Unit unitA = new Plane();
            Unit unitB = new Ship();

            unitA.Operation();
            unitB.Operation();
            unitA.SetImplementor(new ShipMgmtSys());
            unitA.Operation();
        }
    }
}
