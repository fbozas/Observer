using After.ConcreteSubject;
using After.Observer;
using System;

namespace After.ConcreteObservers
{
    public class SpreadSheet : IObserver
    {
        private DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("Spreadsheet got notified " + _dataSource.Value);
        }
    }
}
