using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Array();
            
            int _lengthArray = 0;
            int[] dataArray;

            Console.WriteLine("Opposite values in array.");
            while (true)
            {
                Console.WriteLine("Input length array.");
                array.Verify(Console.ReadLine(), ref _lengthArray);
                while (_lengthArray < 0)
                {
                    Console.WriteLine("The value must be greater than 0 ");
                    array.Verify(Console.ReadLine(), ref _lengthArray);
                }

                dataArray = new int[_lengthArray];
                for (int index = 0; index < _lengthArray; index++)
                {
                    Console.WriteLine($"Input value #{index + 1}");
                    array.Verify(Console.ReadLine(), ref dataArray[index]);
                }

                Console.WriteLine("\nArray before opposite value.");
                array.Show(dataArray);
                array.GetOppositeValueArray(ref dataArray);

                Console.WriteLine("\nArray after opposite value.");
                array.Show(dataArray);

                Console.WriteLine("\n");
                Console.WriteLine("Continue press Enter, Exit press Esc.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            Console.ReadKey();

        }
    }
}
