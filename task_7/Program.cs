using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var array = new Array();

            int _lengthArray = 0;
            int[] _arrayNumbers;

            Console.WriteLine("The program output special numbers.");
            while(true)
            {
                Console.WriteLine("Input length array.");
                array.Verify(Console.ReadLine(), ref _lengthArray);
                while (_lengthArray < 0)
                {
                    Console.WriteLine("The value must be greater than 0 ");
                    array.Verify(Console.ReadLine(), ref _lengthArray);
                }

                _arrayNumbers = new int[_lengthArray];
                for (int index = 0; index < _lengthArray; index++)
                {
                    _arrayNumbers[index] = random.Next(-36, 69);
                    Console.Write($"{_arrayNumbers[index]} ");
                }

                Console.WriteLine("\nResult after operation.");
                array.ShowSpecialValue(_arrayNumbers);         
                Console.WriteLine("\n");
                Console.WriteLine("Continue press Enter, Exit press Esc.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
