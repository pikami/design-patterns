using System;
using TE.FactoryMethod.Factories;
using TE.FactoryMethod.Levels;

namespace TE.FactoryMethod
{
    public class FactoryProgram
    {
        public static void FactoryMain()
        {
            // Head
            Console.WriteLine("\n\n" + new String('-', 20));
            Console.WriteLine("Factory method");
            Console.WriteLine(new String('-', 20));

            // Create factories
            LevelCreator iceCreator = new IceCreator();
            LevelCreator oasisCreator = new OasisCreator();

            // Create concrete objects
            GameLevel iceLevel = iceCreator.CreateLevel();
            GameLevel oasisLevel = oasisCreator.CreateLevel();

            // Print level names
            iceLevel.PrintLevelName();
            oasisLevel.PrintLevelName();
        }
    }
}
