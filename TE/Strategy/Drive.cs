using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Strategy
{
    class Drive : MoveAlgorithm
    {
        public override void MoveDifferently()
        {
            Console.WriteLine("Drive");
        }
    }
}
