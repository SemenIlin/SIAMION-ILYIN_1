using System;
using System.Linq;
namespace task_7
{
    static class OperationWithArray
    {
        public enum Direction 
        {
            Decrease = 1,
            Increase
        }

        private static int[] SortDecrease(int[] array)
        {
            int _temporary;
            for (int index = 0; index < array.Length; index++)
            {
                for (int index1 = index + 1; index1 < array.Length; index1++)
                {
                    if (array[index] < array[index1])
                    {
                        _temporary = array[index];
                        array[index] = array[index1];
                        array[index1] = _temporary;
                    }
                }
            }

            return array;
        }

        private static int[] SortIncrease(int[] array)
        {
            int _temporary;
            for (int index = 0; index < array.Length; index++)
            {
                for (int index1 = index + 1; index1 < array.Length; index1++)
                {
                    if (array[index] > array[index1])
                    {
                        _temporary = array[index];
                        array[index] = array[index1];
                        array[index1] = _temporary;
                    }
                }
            }

            return array;
        }

        public static int[] Sort(this int[] array,Direction direction)
        {
            switch (direction)
            {
                case Direction.Decrease:
                    SortDecrease(array);
                    break;
                case Direction.Increase:
                    SortIncrease(array);
                    break;
                default:
                    SortIncrease(array);
                    break;
            }

            return array;
        }

        public static int[] SortUsingFunc(this int[] array, Direction direction)
        {
            switch (direction)
            {
                case Direction.Decrease:
                    Array.Sort(array);
                    Array.Reverse(array);
                    break;
                case Direction.Increase:
                    Array.Sort(array);
                    break;
                default:
                    Array.Sort(array);
                    break;
            }

            return array;
        }
    }
}
