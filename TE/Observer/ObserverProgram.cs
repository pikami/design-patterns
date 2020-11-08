using System;

namespace TE.Observer
{
    public class ObserverProgram
    {
        public static void ObserverMain()
        {
            // Head
            Console.WriteLine("\n\n" + new String('-', 20));
            Console.WriteLine("Observer");
            Console.WriteLine(new String('-', 20));

            // Create Subject
            Server server = new Server();

            // Create Observers
            Observer ob1 = new ClientMap(server, "ob1");
            Observer ob2 = new ClientMap(server, "ob2");
            Observer ob3 = new ClientMap(server, "ob3");

            // Notify observers
            server.SendMessageToObservers("message 1");
            server.SendMessageToObservers("message 2");
        }
    }
}
