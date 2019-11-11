using System;

namespace task_7
{
    public class Program
    {
        static void Main()
        {
            Random random = new Random();
            var array = new Array();

            int[] _arrayNumbers;

            Console.WriteLine("The program output special numbers.");
            try {
                Console.WriteLine("Input length array.");
                int.TryParse(Console.ReadLine(), out int length);
                _arrayNumbers = new int[length];
                for (int index = 0; index < length; index++)
                {
                    _arrayNumbers[index] = random.Next(-36, 69);
                    Console.Write($"{_arrayNumbers[index]} ");
                }

                Console.WriteLine("\nResult after operation.");
                array.ShowSpecialValue(_arrayNumbers);                               
            }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception.Message);            
            }

            Console.ReadLine();
        }
    }
}