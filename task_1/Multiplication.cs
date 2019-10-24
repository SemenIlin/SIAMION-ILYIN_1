using System;

namespace task_1
{
    class Multiplication
    {
        private int _multiplication;
        readonly string _textValue1;
        readonly string _textValue2;
        private int _value1;
        private int _value2;

        public Multiplication(string text1, string text2)
        {
            _textValue1 = text1;
            _textValue2 = text2;
        }

        private void Verify(string data, out int value)
        {
            while (!int.TryParse(data, out value))
            {
                Console.WriteLine("Input value again.");

                data = Console.ReadLine();
            }
        }

        public int GetResultMultiplication()
        {
            Verify(_textValue1, out _value1);
            Verify(_textValue2, out _value2);
            _multiplication = 0;

            if ((_value1 >= 0) && (_value2 >= 0))
            {
                for (int index = 0; index < _value1; index++)
                {
                    _multiplication += _value2;
                }
            }
            else if ((_value1 < 0) && (_value2 < 0))
            {
                for (int index = _value1; index < 0; index++)
                {
                    _multiplication -= _value2;
                }
            }
            else
            {
                if (_value1 > 0)
                {
                    for (int index = 0; index < _value1; index++)
                    {
                        _multiplication += _value2;
                    }
                }
                else
                {
                    for (int index = 0; index < _value2; index++)
                    {
                        _multiplication += _value1;
                    }
                }
            }

            return _multiplication;
        }
    }
}
