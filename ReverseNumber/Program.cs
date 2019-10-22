using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var reverseNumber = new ReverseNumber();

            var _value = 0;
            Console.WriteLine("The program is reverse number. Max value contain 9 signs");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Input value.");
               
                reverseNumber.Verify(Console.ReadLine(), ref _value);
                _value = reverseNumber.Reverse(_value);
                reverseNumber.Show(_value);

                Console.WriteLine();
                Console.WriteLine("Continue press Enter, Exit press Esc.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.WriteLine();                
            }
        }
    }
}
