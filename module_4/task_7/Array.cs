
namespace task_7
{
    class Array
    {
        public enum Direction 
        {
            Decrease = 1,
            Increase
        }

        private int[] SortDecrease(int[] array)
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

        private int[] SortIncrease(int[] array)
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

        public int[] Sort(Direction direction, int[] array)
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
                    SortDecrease(array);
                    break;
            }

            return array;
        }
    }
}
