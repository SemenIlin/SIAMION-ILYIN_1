using System;

namespace task_2
{
    public class Operation
    {
        public void GetEvenNaturalNumbers(int countValue)
        {
            for (int index = 2; index <= countValue * 2; index += 2)
            {
                Console.Write($"{index} ");
            }
        }
    }
}
