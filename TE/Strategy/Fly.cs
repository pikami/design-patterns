using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Strategy
{
    class Fly : MoveAlgorithm
    {
        public override void MoveDifferently()
        {
            Console.WriteLine("Fly");
        }
    }
}
