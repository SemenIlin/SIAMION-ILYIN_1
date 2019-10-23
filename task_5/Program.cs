using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = new Operation();

            var _number = 0;
            var _digit = 0;

            Console.WriteLine("The program is remove digit from number. Max value number is 2147483647.");

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Input number.");                
                    operation.Verify(Console.ReadLine(), ref _number);
                    Console.WriteLine("Input digit.");
                    operation.VerifyDigit(Console.ReadLine(), ref _digit);

                    _number = operation.RemoveDigit(_number, _digit);
                    operation.Show(_number);

                    Console.WriteLine();
                    Console.WriteLine("Continue press Enter, Exit press Esc.");

                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    Console.WriteLine();
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
