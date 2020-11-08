using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TE.Singleton
{
    class SingletonProgram
    {
        public static void SingletonMain() // idk how you would demo this
        {
            Console.WriteLine("Program started");
            Thread.Sleep(500);
            var s1 = LazyThreadSafeSingleton.GetInstance();
            var s2 = LazyThreadSafeSingleton.GetInstance();
            Console.WriteLine(s1 == s2 ? "Objects are the same" : "Objects are not the same");
        }
    }
}
