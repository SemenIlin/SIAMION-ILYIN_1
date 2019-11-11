using System;

namespace task_1
{
    public class Program
    {
        static void Main()
        {
            int _multiplication;            

            var multiplication = new Multiplication();

            Console.WriteLine("The program for finding the result of multiplication.");
            try
            {
                Console.WriteLine("Input first value.");
                int.TryParse(Console.ReadLine(), out int value1);
                Console.WriteLine("Input second value.");
                int.TryParse(Console.ReadLine(), out int value2);                

                _multiplication = multiplication.GetResultMultiplication(value1, value2);
                Console.WriteLine($"Result is {_multiplication}");
            }
            catch (InvalidCastException exception)
            {
                Console.WriteLine(exception.Message);            
            }

            Console.ReadLine();
        }
    }
}
