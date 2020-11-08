using System;
using System.Collections.Generic;
using System.Text;

namespace TE.AbstractFactory
{
    public class AbstractFactoryProgram
    {
        public static void AbstractFactoryMain()
        {
            // Head
            Console.WriteLine("\n\n" + new String('-', 20));
            Console.WriteLine("AbstractFactory method");
            Console.WriteLine(new String('-', 20));

            AbstractFactory factory1 = new ConcreteFactory1();
            AbstractFactory factory2 = new ConcreteFactory2();
            Console.WriteLine("AbstractFactory 1#");
            factory1.CreateProduct1().name();
            factory1.CreateProduct2().name();
            Console.WriteLine("AbstractFactory 2#");
            factory2.CreateProduct1().name();
            factory2.CreateProduct2().name();
        }
    }
}
