using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program to output a series of natural even numbers.");

            Console.WriteLine();
            Console.WriteLine("Input value.");
            var count = Console.ReadLine();

            var operation = new EvenNumbers(count);
            var data = operation.GetNumbersFibonacci();

            foreach (var item in data)
            {
                Console.Write($"{item} ");            
            }

            Console.ReadLine();
        }
    }
}
