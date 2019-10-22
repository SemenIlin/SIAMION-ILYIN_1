using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = new Operation();

            var _value = 0;
            Console.WriteLine("The program to output a series of natural even numbers.");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Input value.");
                operation.Verify(Console.ReadLine(), ref _value);
                operation.Show(_value);

                Console.WriteLine();
                Console.WriteLine("Continue press Enter, Exit press Esc.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
