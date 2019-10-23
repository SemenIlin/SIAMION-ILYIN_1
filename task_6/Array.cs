using System;

namespace task_6
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

        public int[] GetOppositeValueArray(ref int[] array) 
        {
            for(int index = 0; index < array.Length; index++)
            {
                array[index] = -array[index]; 
            }

            return array;
        }

        public void Show(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
