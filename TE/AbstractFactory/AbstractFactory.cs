using System;
using System.Collections.Generic;
using System.Text;

namespace TE.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProduct1 CreateProduct1();
        public abstract AbstractProduct2 CreateProduct2();
    }
}
