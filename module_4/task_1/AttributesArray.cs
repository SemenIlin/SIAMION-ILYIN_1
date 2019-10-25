namespace task_1
{
    class AttributesArray
    {
        public int MaxElement(int[] array)
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

        public double MaxElement(double[] array)
        {
            double maxValue = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] > maxValue)
                {
                    maxValue = array[index];
                }
            }

            return maxValue;
        }

        public int MinElement(int[] array)
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

        public double MinElement(double[] array)
        {
            double minValue = array[0];
            for (int index = 1; index < array.Length; index++)
            {
                if (array[index] < minValue)
                {
                    minValue = array[index];
                }
            }

            return minValue;
        }

        public int Sum(int[] array)
        {
            int sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }

            return sum;
        }

        public double Sum(double[] array)
        {
            double sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }

            return sum;
        }

        public int DifferenceBetweenMaxAndMin(int[] array)
        {
            int max = MaxElement(array);
            int min = MinElement(array);

            return max - min;
        }

        public double DifferenceBetweenMaxAndMin(double[] array)
        {
            double min = MinElement(array);
            double max = MaxElement(array);

            return max - min;
        }

        public int[] CreateNewArray(int[] array)
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

        public double[] CreateNewArray(double[] array)
        {
            double maxElement = MaxElement(array);
            double minElement = MinElement(array);
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
