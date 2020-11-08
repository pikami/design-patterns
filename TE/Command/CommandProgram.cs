using System;
using System.Collections.Generic;

namespace TE.Command
{
    public class CommandProgram
    {
        public static void CommandMain()
        {
            // Head
            Console.WriteLine("\n\n" + new String('-', 20));
            Console.WriteLine("Facade");
            Console.WriteLine(new String('-', 20));

            // Create player
            Player player = new Player();

            // Create commands
            List<Command> commands = new List<Command>()
            {
                new UpCommand(player),
                new UpCommand(player),
                new LeftCommand(player),
                new LeftCommand(player),
                new DownCommand(player),
                new DownCommand(player),
                new RightCommand(player),
            };

            // Execute commands
            commands.ForEach(x => x.Move());

            // Undo commands
            commands.Reverse();
            commands.ForEach(x => x.Undo());
        }
    }
}
