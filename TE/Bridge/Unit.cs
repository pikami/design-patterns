using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TE.Bridge
{
    class Unit
    {
        protected UnitMgmtSys implementor;

        public void SetImplementor(UnitMgmtSys implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            Console.WriteLine($"Unit of type {GetType()} executing operation");
            implementor.Operation();
        }
    }
}
