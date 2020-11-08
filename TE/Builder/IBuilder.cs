using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Builder
{
    public abstract class IBuilder
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract Shit GetResult();
    }
}
