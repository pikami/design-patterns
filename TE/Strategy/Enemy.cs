using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Strategy
{
    class Enemy
    {
        // note that algorithm is asssociated to enemy like a list in magicdraw
        // but not in implementation as i understand it
        MoveAlgorithm moveOperation;

        public Enemy()
        {
            moveOperation = new Drive();
        }

        public void Move()
        {
            moveOperation.MoveDifferently();
        }

        public void SetAlgorithm(MoveAlgorithm ma)
        {
            moveOperation = ma;
        }
    }
}
