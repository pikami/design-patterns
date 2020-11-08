using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Adapter
{
    class Ship // Client
    {
        RefillAdapter refillAdapter = new ConcreteAdapter();

        public void Refill()
        {
            refillAdapter.RefillAdaptee();
        }
    }
}
