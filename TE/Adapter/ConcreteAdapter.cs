using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Adapter
{
    class ConcreteAdapter : RefillAdapter // Adapter
    {
        Nuclear nuclear = new Nuclear();

        public override void RefillAdaptee() // Request
        {
            nuclear.Change();
        }
    }
}
