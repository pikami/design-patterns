using System;
using TE.AbstractFactory;
using TE.Adapter;
using TE.Bridge;
using TE.Decorator;
using TE.Command;
using TE.Facade;
using TE.FactoryMethod;
using TE.Observer;
using TE.Prototype;
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
            AbstractFactoryProgram.AbstractFactoryMain();
            DecoratorProgram.DecoratorMain();
            CommandProgram.CommandMain();
            PrototypeProgram.PrototypeMain();
        }
    }
}
