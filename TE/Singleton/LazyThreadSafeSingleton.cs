using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Singleton
{
    class LazyThreadSafeSingleton
    {
        private static readonly Lazy<LazyThreadSafeSingleton> lazy =
            new Lazy<LazyThreadSafeSingleton>(() => new LazyThreadSafeSingleton());

        private LazyThreadSafeSingleton()
        {
            Console.WriteLine("lazy instantiation");
        }

        public static LazyThreadSafeSingleton GetInstance()
        {
            return lazy.Value;
        }

        //private static readonly Lazy<GameHubClient> lazy =
        //new Lazy<GameHubClient>(() => new GameHubClient());

        //public static GameHubClient Instance { get { return lazy.Value; } }

        //private GameHubClient()
        //{

        //}
    }
}
