using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Decorator
{
    public class ConcreteDecorator1 : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
