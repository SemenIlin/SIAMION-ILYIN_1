using System;

namespace task_6
{
    class Array
    {
        public int[] IncreaseValuesOfArray(int[] array)
        {
            for(int index = 0; index < array.Length; index++)
            {
                array[index] += 5;
            }

            return array;
        }

        public double[] IncreaseValuesOfArray(double[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                array[index] += 5.0;
            }

            return array;
        }

        public void Show<T>(T[] array)
        {
            foreach (var value in array)
            {
                Console.Write($"{value} ");            
            }
        }

    }
}
