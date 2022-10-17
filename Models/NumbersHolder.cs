namespace Api_training1.Models
{
    public class NumbersHolder
    {
        private Numbers _values;

        public NumbersHolder()
        {
            _values = new Numbers();
        }

        public void Add(int number1, int number2)
        {
            _values.Number1 = number1;
            _values.Number2 = number2;
        }

        public int Get()
        {
            return _values.Sum;
        }

    }
}
