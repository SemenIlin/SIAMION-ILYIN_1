using System;

namespace task_5
{
    class Operation
    {
        readonly string _textNumber;
        readonly string _textDigit;
        private int _number;
        private int _digit;
        private string _result = "";

        public Operation(string number, string digit)
        {
            _textNumber = number;
            _textDigit = digit;
        }
        
        private void VerifyNumber(string data, out int number)
        {
            while ((!int.TryParse(data, out number)) || (number <= 0))
            {
                Console.WriteLine("Incorrect data, input number again, please.");

                data = Console.ReadLine();
            }
        }

        private void VerifyDigit(string data, out int digit)
        {
            while ((!int.TryParse(data, out digit)) || (digit <= 0) || (digit > 9) )
            {
                Console.WriteLine("Incorrect data, input digit again, please.");

                data = Console.ReadLine();
            }
        }
       
        public int GetNewNumber()
        {
            VerifyNumber(_textNumber, out _number);
            VerifyDigit(_textDigit, out _digit);            

            while (true)
            {
                if ((_number % 10) == _digit)
                {
                    _number /= 10;

                    continue;
                }

                _result = _number % 10 + _result;
                if (_number / 10 <= 0)
                {
                    break;
                }

                _number /= 10;
            }

            return int.TryParse(_result, out int result) ? result : 0; 
        }
    }
}
