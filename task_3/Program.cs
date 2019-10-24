using System;
using System.Collections.Generic;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowFibonacci = new List<decimal>();

            Console.WriteLine("The program output Fibonacci series. Maximum 140.");

            Console.WriteLine("Input value.");
            try
            {
                var count = Console.ReadLine();

                var fibonacci = new Fibonacci(count);
                rowFibonacci = fibonacci.GetRowFibonacci();

                Console.WriteLine($"Fibonacci series of {rowFibonacci.Count} elements.");
                foreach (var value in rowFibonacci)
                {
                    Console.Write($"{value} ");
                }               
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
    }
}
