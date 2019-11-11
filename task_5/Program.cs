using System;

namespace task_5
{
    public class Program
    {
        static void Main()
        {
            int digit;
            Console.WriteLine("The program is remove digit from number. Max value number is 2147483647.");           
            Console.WriteLine();
            try
            {
                Console.WriteLine("Input number.");
                int.TryParse(Console.ReadLine(), out int numbers);
                Console.WriteLine("Input digit.");
                digit = int.TryParse(Console.ReadLine(), out digit) ? (digit >= 0 && digit <= 9 ? digit : throw new Exception("Value should be from 0 to 9."))  : throw new InvalidCastException();
                var operation = new Operation(numbers, digit);
                
                Console.WriteLine($"New number is {operation.GetNewNumber()}");
            }
            catch (InvalidCastException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);            
            }

            Console.ReadLine();
        }
    }
}