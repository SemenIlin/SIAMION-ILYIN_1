using System;

namespace task_7
{
    public class Array
    {
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
