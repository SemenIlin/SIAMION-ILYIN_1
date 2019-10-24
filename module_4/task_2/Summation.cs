using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Summation
    {
        public int Sum(int value1, int value2, int value3) => value1 + value2 + value3;

        public int Sum(int value1, int value2) => value1 + value2;

        public double Sum(double value1, double value2, double value3) => value1 + value2 + value3;

        public string Concat(string txt1, string txt2) => String.Concat(txt1, txt2);

        public int[] SumArray(int[] array1, int[] array2)
        {
            int[] result;
            if(array1.Length == array2.Length)
            {
                result = new int[array2.Length];
                for (int index = 0; index < array2.Length; index++)
                {
                    result[index] = array1[index] + array2[index];                
                }
            }
            else if (array1.Length > array2.Length)
            {
                result = new int[array1.Length];
                for (int index = 0; index < array2.Length; index++)
                {
                    result[index] = array1[index] + array2[index];
                }

                for (int index = array2.Length; index < array1.Length; index++)
                {
                    result[index] = array1[index];
                }
            }
            else 
            {
                result = new int[array2.Length];
                for (int index = 0; index < array1.Length; index++)
                {
                    result[index] = array1[index] + array2[index];
                }

                for (int index = array1.Length; index < array2.Length; index++)
                {
                    result[index] = array2[index];
                }
            }

            return result;
        }

        public void Show<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }      
    }
}
