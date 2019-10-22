using System;
using System.Collections.Generic;

namespace task_3
{
    class Fibonacci
    {
        public void Verify(string data, ref int value)
        {
            while ((!int.TryParse(data, out value)) || (value <= 0))
            {
                Console.WriteLine("Incorrect data, input value again, please.");

                data = Console.ReadLine();
            }
        }

        // For very long series Fibonacci(140).
        public List<decimal> GetRowFibonacci(int countValue)
        {
            List<decimal> numbersFibonacci = new List<decimal>();
            if (countValue == 1)
            {
                numbersFibonacci.Add(0);
            }
            else if (countValue == 2)
            {
                numbersFibonacci.Add(0);
                numbersFibonacci.Add(1);
            }
            else
            {
                decimal tempValue;
                numbersFibonacci.Add(0);
                numbersFibonacci.Add(1);

                for (int index = 2; index < countValue; index++)
                {
                    tempValue = numbersFibonacci[index - 1] + numbersFibonacci[index - 2];
                    numbersFibonacci.Add(tempValue);
                } 
            }

            return numbersFibonacci;
        }

        public void Show(List<decimal> rowFibonacci)
        {
            Console.WriteLine($"Fibonacci series of {rowFibonacci.Count} elements.");
            foreach (var value in rowFibonacci)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
