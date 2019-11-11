namespace task_6
{
    public class Array
    {
        public int[] GetOppositeValueArray(int[] array) 
        {
            for(int index = 0; index < array.Length; index++)
            {
                array[index] = -array[index]; 
            }

            return array;
        }
    }
}
