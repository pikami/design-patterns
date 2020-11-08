using System.Collections.Generic;

namespace TE.Observer
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Subscribe(Observer observer) => observers.Add(observer);

        public void UnSubscribe(Observer observer) => observers.Remove(observer);

        protected void NotifyObservers(string message) => observers.ForEach(x => x.Update(message));
    }
}
