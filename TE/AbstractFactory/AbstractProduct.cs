using System;
using System.Collections.Generic;
using System.Text;

namespace TE.AbstractFactory
{
    public class AbstractProduct
    {
        public void name()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
