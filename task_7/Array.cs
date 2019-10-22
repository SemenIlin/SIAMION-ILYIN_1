using System;

namespace task_7
{
    class Array
    {
        public void Verify(string data, ref int value)
        {
            while (!int.TryParse(data, out value))
            {
                Console.WriteLine("Input value again.");

                data = Console.ReadLine();
            }
        }

        public void ShowSpecialValue(int[] array)
        {
            for(int index = 1; index < array.Length; index++)
            {
                if (array[index] > array[index - 1])
                {
                    Console.Write($"{array[index]} ");
                }
            }            
        }
    }
}
