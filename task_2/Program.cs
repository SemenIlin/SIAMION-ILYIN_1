using System;

namespace task_2
{
    public class Program
    {
        static void Main()
        {
            var operation = new Operation();

            Console.WriteLine("The program to output a series of natural even numbers.");
           
            Console.WriteLine("Input value.");
            int.TryParse(Console.ReadLine(), out int value);
            operation.GetEvenNaturalNumbers(value);           

            Console.ReadLine();            
        }
    }
}
