using System;
    
namespace task_3
{
    class RefAndOut
    {
        public void IncreaseNumbers(ref int value1, ref int value2, ref int value3)
        {
            value1 += 10;
            value2 += 10;
            value3 += 10;
        }

        public void IncreaseNumbers(ref double value1, ref double value2, ref double value3)
        {
            value1 += 10;
            value2 += 10;
            value3 += 10;
        }

        public void GetLengthAndSquareCircle(double radius, out double length, out double square)
        {
            length = 2 * Math.PI * radius;
            square = Math.Pow(radius, 2) * Math.PI;
        }

        public void GetMinMaxAndSum(int[] array, out int min, out int max, out int sum)
        {
            min = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                }
            }

            max = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
            }

            sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }
        }

        public void GetMinMaxAndSum(double[] array, out double min, out double max, out double sum)
        {
            min = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                }
            }

            max = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
            }

            sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }
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
