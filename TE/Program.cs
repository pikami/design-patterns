using System;
using TE.Adapter;
using TE.Bridge;
using TE.Facade;
using TE.FactoryMethod;
using TE.Observer;
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
            FacadeProgram.FacadeMain();
            FactoryProgram.FactoryMain();
            ObserverProgram.ObserverMain();
        }
    }
}
