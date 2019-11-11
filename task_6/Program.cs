using System;

namespace task_6
{
    public class Program
    {
        static void Main()
        {
            Random random = new Random();
               
            var array = new Array();
            
            int[] dataArray;

            Console.WriteLine("Opposite values in array.");
            try
            {
                Console.WriteLine("Input length array.");
                int.TryParse(Console.ReadLine(), out int length);              
                dataArray = new int[length];
                for (int index = 0; index < length; index++)
                {
                    dataArray[index] = random.Next(-36, 69);
                }

                Console.WriteLine("\nArray before opposite value.");
                foreach (var item in dataArray)
                {
                    Console.Write(item + " ");                
                }

                dataArray = array.GetOppositeValueArray(dataArray);

                Console.WriteLine("\nArray after opposite value.");
                foreach (var item in dataArray)
                {
                    Console.Write(item + " ");
                }
            }
            catch(OverflowException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadKey();
        }
    }
}