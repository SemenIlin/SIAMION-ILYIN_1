using System.Collections;
using System.Collections.Generic;

namespace task_3
{
    public class Fibonacci : IEnumerable
    {
        private readonly List<decimal> numbersFibonacci;

        public Fibonacci(int countValue)
        {
            numbersFibonacci = new List<decimal>();
            if (countValue == 1)
            {
                numbersFibonacci.Add(0);
            }
            else if (countValue == 2)
            {
                numbersFibonacci.Add(0);
                numbersFibonacci.Add(1);
            }
            else if (countValue > 2)
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
        }

        public IEnumerator GetEnumerator()
        {
            return numbersFibonacci.GetEnumerator();        
        }
    }
}
