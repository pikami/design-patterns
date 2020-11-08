using System;

namespace TE.Command
{
    public class LeftCommand : Command
    {
        private Player player;

        public LeftCommand(Player player)
        {
            this.player = player;
        }

        public void Move()
        {
            player.Move("left");
            Console.WriteLine($"Player moved left, current position: {player.GetPosition()}");
        }

        public void Undo()
        {
            player.Move("right");
            Console.WriteLine($"Undo move left, current position: {player.GetPosition()}");
        }
    }
}
