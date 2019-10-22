using System;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var vortexArray = new VortexArray();

            int _lengthArray = 0;
            int[,] _array;

            Console.WriteLine("The program for create vortex array.");
            while (true)
            {
                Console.WriteLine("Input length array.");
                vortexArray.Verify(Console.ReadLine(), ref _lengthArray);
                while (_lengthArray < 0)
                {
                    Console.WriteLine("The value must be greater than 0 ");
                    vortexArray.Verify(Console.ReadLine(), ref _lengthArray);
                }

                _array = vortexArray.CreateVortexArray(_lengthArray);
                vortexArray.Show(_array);
                
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
