
namespace task_6
{
    static class OperationWithArray
    {
        public static int[] IncreaseValuesOfArray(this int[] array)
        {
            for(int index = 0; index < array.Length; index++)
            {
                array[index] += 5;
            }

            return array;
        }
    }
}
