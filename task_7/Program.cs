using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("The program output special numbers.");
           
            Console.WriteLine("Input length array.");
            var length = Console.ReadLine();
            var arrayClass = new Array(length);

            var array = arrayClass.GetArray();
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nResult after operation.");
            var result = arrayClass.GetSpecialValue(array);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
