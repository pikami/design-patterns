using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Adapter
{
    class Nuclear // Adaptee
    {
        public void Change() // Specific Request
        {
            Console.WriteLine("Called specific request");
        }
    }
}
