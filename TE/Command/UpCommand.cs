using System;

namespace TE.Command
{
    public class UpCommand : Command
    {
        private Player player;

        public UpCommand(Player player)
        {
            this.player = player;
        }

        public void Move()
        {
            player.Move("up");
            Console.WriteLine($"Player moved up, current position: {player.GetPosition()}");
        }

        public void Undo()
        {
            player.Move("down");
            Console.WriteLine($"Undo move up, current position: {player.GetPosition()}");
        }
    }
}
