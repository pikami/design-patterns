using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Decorator
{
    public class ConcreteDecorator2 : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddedBehavior()
        {
        }
    }
}
