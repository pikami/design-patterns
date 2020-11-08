using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TE.Adapter
{
    class AdapterProgram 
    {
        // kontrolinio pasiruosime Program padare client'u
        // Unit buvo target, ji paveldejo adapteris kuris isverte left() right()... i move(x, y):
        // left paveldetas butu move(-1, 0), right - move(1, 0) ir t.t.
        public static void AdapterMain()
        {   
            Ship ship = new Ship();
            ship.Refill();
        }
    }
}
