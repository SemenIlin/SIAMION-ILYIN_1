using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opposite values in array.");
            
            Console.WriteLine("Input length array.");
            var length = Console.ReadLine();
            var arrayClass = new Array(length);

            var array = arrayClass.GetArray();
            Console.WriteLine("\nArray before opposite value.");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            array = arrayClass.GetOppositeValueArray(array);
            Console.WriteLine("\nArray after opposite value.");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
