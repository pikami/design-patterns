using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Decorator
{
    public class DecoratorProgram
    {
        public static void DecoratorMain()
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecorator1 d1 = new ConcreteDecorator1();
            ConcreteDecorator2 d2 = new ConcreteDecorator2();


            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            // Head
            Console.WriteLine("\n\n" + new String('-', 20));
            Console.WriteLine("Decorator method");
            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Decorator 1#");
            d1.Operation();
            Console.WriteLine("Decorator 2#");
            d2.Operation();
        }
    }
}
