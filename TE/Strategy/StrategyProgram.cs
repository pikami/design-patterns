using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Strategy
{
    class StrategyProgram
    {
        public static void StrategyMain() // demo 100
        {
            Enemy enemy = new Enemy();
            enemy.SetAlgorithm(new Drive());
            enemy.Move();
            enemy.SetAlgorithm(new Fly());
            enemy.Move();
            enemy.Move();
            enemy.SetAlgorithm(new Drive());
            enemy.Move();
        }
    }
}
