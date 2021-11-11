using After.Observer;
using System;

namespace After.ConcreteObservers
{
    public class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart got notified");
        }
    }
}
