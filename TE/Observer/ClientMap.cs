using System;

namespace TE.Observer
{
    public class ClientMap : Observer
    {
		public string Name;

		public ClientMap(Server subject, string name)
		{
			subject.Subscribe(this);
			Name = name;
		}

        public void Update(string message)
        {
			Console.WriteLine($"[{Name}] Got message: {message}");
		}
	}
}
