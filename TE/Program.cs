using System;
using TE.Adapter;
using TE.Bridge;
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
            BridgeProgram.BridgeMain();
        }
    }
}
