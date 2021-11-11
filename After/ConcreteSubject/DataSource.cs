using After.Subject;

namespace After.ConcreteSubject
{
    public class DataSource : MySubject
    {
        private int _value;

        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                NotifyObservers(_value);
            }
        }
    }
}
