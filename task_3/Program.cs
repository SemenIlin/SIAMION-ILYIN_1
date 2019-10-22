using System;
using System.Collections.Generic;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = new Fibonacci();

            var _value = 0;
            var rowFibonacci = new List<decimal>();

            Console.WriteLine("The program output Fibonacci series. Maximum 140.");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Input value.");
                try
                {
                    fibonacci.Verify(Console.ReadLine(), ref _value);
                    rowFibonacci = fibonacci.GetRowFibonacci(_value);
                    fibonacci.Show(rowFibonacci);

                    Console.WriteLine();
                    Console.WriteLine("Continue press Enter, Exit press Esc.");

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    Console.WriteLine();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            
            }
        }
    }
}
