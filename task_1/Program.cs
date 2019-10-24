using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program for finding the result of multiplication.");

            Console.WriteLine("Input first value.");
            var value1 = Console.ReadLine();
            Console.WriteLine("Input second value.");
            var value2 =Console.ReadLine();

            var multiplication = new Multiplication(value1, value2);
            var result = multiplication.GetResultMultiplication();

            Console.WriteLine($"Result = {result}.");

            Console.ReadLine();
        }
    }
}
