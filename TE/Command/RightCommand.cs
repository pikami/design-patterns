using System;

namespace TE.Command
{
    public class RightCommand : Command
    {
        private Player player;

        public RightCommand(Player player)
        {
            this.player = player;
        }

        public void Move()
        {
            player.Move("right");
            Console.WriteLine($"Player moved right, current position: {player.GetPosition()}");
        }

        public void Undo()
        {
            player.Move("left");
            Console.WriteLine($"Undo move right, current position: {player.GetPosition()}");
        }
    }
}
