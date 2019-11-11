using System.Linq;

namespace task_1
{
    static class AttributesArray
    {
        public static int MaxElement(this int[] array)
        {
            int maxValue = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] > maxValue)
                {
                    maxValue = array[index];
                }
            }

            return maxValue;
        }

        public static int MaxElementUsingFunc(this int[] array)
        {
            return array.Max();
        }

        public static int MinElement(int[] array)
        {
            int minValue = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] < minValue)
                {
                    minValue = array[index];
                }
            }

            return minValue;
        }

        public static int MinElementUsingFunc(this int[] array)
        {
            return array.Min();        
        }

        public static int Sum(this int[] array)
        {
            int sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }

            return sum;
        }

        public static int SumUsingFunc(this int[] array)
        {
            return array.Sum();
        }

        public static int DifferenceBetweenMaxAndMin(this int[] array)
        {
            int max = MaxElement(array);
            int min = MinElement(array);

            return max - min;
        }        

        public static int[] CreateNewArray(this int[] array)
        {
            int maxElement = MaxElement(array);
            int minElement = MinElement(array);
            for (int index = 0; index < array.Length; index++)
            {
                if (index % 2 == 0)
                {
                    array[index] += maxElement;
                }
                else
                {
                    array[index] -= minElement;
                }
            }

            return array;
        }
    }
}
