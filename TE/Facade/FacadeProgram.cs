using System;

namespace TE.Facade
{
    public class FacadeProgram
    {
        public static void FacadeMain()
        {
            // Head
            Console.WriteLine("\n\n" + new String('-', 20));
            Console.WriteLine("Facade");
            Console.WriteLine(new String('-', 20));

            // Create Facade
            Facade facade = new Facade();

            // Get value
            var value = facade.GetValue();
            Console.WriteLine($"Got '{value}' from facade");
        }
    }
}
