using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var _value1 = 0;
            var _value2 = 0;
            var _multiplication = 0;            

            var multiplication = new Multiplication();

            Console.WriteLine("The program for finding the result of multiplication.");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Input first value.");
                multiplication.Verify(Console.ReadLine(), ref _value1);
                Console.WriteLine("Input second value.");
                multiplication.Verify(Console.ReadLine(), ref _value2);

                _multiplication = multiplication.GetResultMultiplication(_value1, _value2);

                multiplication.Show(_multiplication);

                Console.WriteLine();
                Console.WriteLine("Continue press Enter, Exit press Esc. ");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
