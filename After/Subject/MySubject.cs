using After.Observer;
using System.Collections.Generic;

namespace After.Subject
{
    public class MySubject
    {
        List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(int val)
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(val);
            }
        }
    }
}
