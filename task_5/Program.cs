using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program is remove digit from number. Max value number is 2147483647.");

            try
            {
                Console.WriteLine("Input number.");
                var number =Console.ReadLine();
                Console.WriteLine("Input digit.");
                var digit = Console.ReadLine();

                var operation = new Operation(number, digit);
                Console.WriteLine($"Result is {operation.GetNewNumber()}.");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
    }
}
