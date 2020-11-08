using System;

namespace TE.FactoryMethod.Levels
{
    public abstract class GameLevel
    {
        public void PrintLevelName()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
