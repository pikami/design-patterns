using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Prototype
{
    public interface IPrototype
    {
        public IPrototype shallowClone();
        public IPrototype deepClone();
    }
}
