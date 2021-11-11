using After.Observer;
using System;

namespace After.ConcreteObservers
{
    public class Chart : IObserver
    {
        public void Update(int val)
        {
            Console.WriteLine("Chart got notified " + val);
        }
    }
}
