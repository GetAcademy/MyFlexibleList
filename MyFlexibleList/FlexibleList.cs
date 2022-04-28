namespace MyFlexibleList
{
    internal class FlexibleList<T>
    {
        private T[] _values = new T[4];
        private int _count = 0;

        public void Add(T value)
        {
            if (_count >= _values.Length)
            {
                //Array.Resize(ref numbers, numbers.Length*2);
                var newNumbers = new T[_values.Length * 2];
                Array.Copy(_values, newNumbers, _values.Length);
                //Console.WriteLine($"Dobler kapasitet fra {_values.Length} til {newNumbers.Length}");
                _values = newNumbers;
            }
            _values[_count] = value;
            _count++;
        }

        public string GetValues()
        {
            return string.Join(", ", _values);
        }

    }
}
