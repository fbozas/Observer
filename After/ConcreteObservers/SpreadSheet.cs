using After.Observer;
using System;

namespace After.ConcreteObservers
{
    public class SpreadSheet : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Spreadsheet got notified");
        }
    }
}
