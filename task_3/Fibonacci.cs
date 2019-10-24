using System;
using System.Collections.Generic;

namespace task_3
{
    class Fibonacci
    {
        readonly string _textCount;
        private int _count;

        public Fibonacci(string count)
        {
            _textCount = count;        
        }

        private void Verify(string data, out int value)
        {
            while ((!int.TryParse(data, out value)) || (value <= 0))
            {
                Console.WriteLine("Incorrect data, input value again, please.");

                data = Console.ReadLine();
            }
        }

        // For very long series Fibonacci(140).
        public List<decimal> GetRowFibonacci()
        {
            Verify(_textCount, out _count);
            List<decimal> numbersFibonacci = new List<decimal>();
            if (_count == 1)
            {
                numbersFibonacci.Add(0);
            }
            else if (_count == 2)
            {
                numbersFibonacci.Add(0);
                numbersFibonacci.Add(1);
            }
            else
            {
                decimal tempValue;
                numbersFibonacci.Add(0);
                numbersFibonacci.Add(1);

                for (int index = 2; index < _count; index++)
                {
                    tempValue = numbersFibonacci[index - 1] + numbersFibonacci[index - 2];
                    numbersFibonacci.Add(tempValue);
                } 
            }

            return numbersFibonacci;
        }
    }
}
