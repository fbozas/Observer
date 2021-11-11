using After.ConcreteObservers;
using After.ConcreteSubject;

namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource dataSource = new DataSource();

            var sheet1 = new SpreadSheet(dataSource);
            var sheet2 = new SpreadSheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.RemoveObserver(sheet2);


            dataSource.Value = 1;
        }
    }
}
