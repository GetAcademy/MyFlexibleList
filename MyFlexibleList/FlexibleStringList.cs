namespace MyFlexibleList
{
    internal class FlexibleStringList
    {
        private string[] _numbers = new string[4];
        private int _count = 0;

        public void AddNumber(string number)
        {
            if (_count >= _numbers.Length)
            {
                //Array.Resize(ref numbers, numbers.Length*2);
                var newNumbers = new string[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                //Console.WriteLine($"Dobler kapasitet fra {_numbers.Length} til {newNumbers.Length}");
                _numbers = newNumbers;
            }
            _numbers[_count] = number;
            _count++;
        }

        public string GetValues()
        {
            return string.Join(", ", _numbers);
        }
    }
}
