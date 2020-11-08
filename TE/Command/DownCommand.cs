using System;

namespace TE.Command
{
    public class DownCommand : Command
    {
        private Player player;

        public DownCommand(Player player)
        {
            this.player = player;
        }

        public void Move()
        {
            player.Move("down");
            Console.WriteLine($"Player moved down, current position: {player.GetPosition()}");
        }

        public void Undo()
        {
            player.Move("up");
            Console.WriteLine($"Undo move down, current position: {player.GetPosition()}");
        }
    }
}
