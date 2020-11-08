using TE.Adapter;
using TE.FactoryMethod;
using TE.Singleton;
using TE.Strategy;

namespace TE
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterProgram.AdapterMain();
            SingletonProgram.SingletonMain();
            StrategyProgram.StrategyMain();
            FactoryProgram.FactoryMain();
        }
    }
}
