using System;

namespace task_1
{
    class Multiplication
    {
        private int _multiplication;

        public void Verify(string data, ref int value)
        {
            while (!int.TryParse(data, out value))
            {
                Console.WriteLine("Input value again.");

                data = Console.ReadLine();
            }
        }

        public int GetResultMultiplication(int value1, int value2)
        {
            _multiplication = 0;

            if ((value1 >= 0) && (value2 >= 0))
            {
                for (int index = 0; index < value1; index++)
                {
                    _multiplication += value2;
                }
            }
            else if ((value1 < 0) && (value2 < 0))
            {
                for (int index = value1; index < 0; index++)
                {
                    _multiplication -= value2;
                }
            }
            else
            {
                if (value1 > 0)
                {
                    for (int index = 0; index < value1; index++)
                    {
                        _multiplication += value2;
                    }
                }
                else
                {
                    for (int index = 0; index < value2; index++)
                    {
                        _multiplication += value1;
                    }
                }
            }

            return _multiplication;
        }

        public void Show(int multiplication)
        {
            Console.WriteLine($"Result of multipliction is {multiplication}.");
        }
    }
}
