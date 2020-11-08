using System;
using System.Collections.Generic;
using System.Text;

namespace TE.AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProduct1 CreateProduct1()
        {
            return new P1_1();
        }

        public override AbstractProduct2 CreateProduct2()
        {
            return new P1_2();
        }
    }
}
