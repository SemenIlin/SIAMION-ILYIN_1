using System;
using System.Collections.Generic;
using System.Text;

namespace task_4
{
    class Tuple
    {
        public (int Value1, int Value2, int Value3) GetIncreaseNumbers(int value1, int value2, int value3)
        {
            value1 += 10;
            value2 += 10;
            value3 += 10;

            return (value1, value2, value3);         
        }

        public (double Value1, double Value2, double Value3) GetIncreaseNumbers(double value1, double value2, double value3)
        {
            value1 += 10;
            value2 += 10;
            value3 += 10;

            return (value1, value2, value3);
        }

        public (double Length, double Square) GetLengthAndSquareCircle(double radius)
        {
            var length = 2 * Math.PI * radius;
            var square = Math.Pow(radius, 2) * Math.PI;

            return (length, square);
        }

        public (int Min, int Max, int Sum) GetMinMaxAndSum(int[] array)
        {
            var min = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                }
            }

            var max = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
            }

            var sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }

            return (min, max, sum);
        }

        public (double Min, double Max, double Sum) GetMinMaxAndSum(double[] array)
        {            
            var min = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                }
            }

            var max = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
            }

            var sum = 0.0;
            for (int index = 0; index < array.Length; index++)
            {
               sum += array[index];
            }

            return (min, max, sum);
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
