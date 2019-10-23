using System;

namespace task_2
{
    class Operation
    {
        public void Verify(string data, ref int value)
        {
            while ((!int.TryParse(data, out value)) || (value < 0))
            {
                Console.WriteLine("Incorrect data, input value again, please.");

                data = Console.ReadLine();
            }
        }

        public void Show(int countValue)
        {
            for (int index = 2; index <= countValue * 2; index += 2)
            {
                Console.Write($"{index} ");
            }
        }
    }
}
