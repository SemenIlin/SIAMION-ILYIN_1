
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
    }
}
