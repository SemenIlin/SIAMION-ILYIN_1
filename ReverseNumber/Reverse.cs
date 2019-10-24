using System;

namespace ReverseNumber
{
    class Reverse
    {
        readonly string _textNumer;
        private int _number;
        private string _result = "";

        public Reverse(string number)
        {
            _textNumer = number;
        }
        
        private void Verify(string data, out int value)
        {
            while ((!int.TryParse(data, out value)) || (value <= 0))
            {
                Console.WriteLine("Incorrect data, input value again, please.");

                data = Console.ReadLine();
            }
        }

        public int GetReverseNumber()
        {
            Verify(_textNumer, out _number);

            while (true)
            {
                _result += _number % 10;
                if((_number / 10) <= 0)
                {
                    break;
                }

                _number /= 10;
            }

            return int.TryParse(_result, out _number) ? _number : 0;
        }
    }
}
