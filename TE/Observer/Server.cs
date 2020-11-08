namespace TE.Observer
{
    public class Server : Subject
	{
		public void SendMessageToObservers(string message)
        {
            NotifyObservers(message);
        }
	}
}
