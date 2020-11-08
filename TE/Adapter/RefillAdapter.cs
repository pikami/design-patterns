using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Adapter
{
    class RefillAdapter // Target
    {
        public virtual void RefillAdaptee() // Request
        {
            Console.WriteLine("Called Adapter interface request");
        }
    }
}
