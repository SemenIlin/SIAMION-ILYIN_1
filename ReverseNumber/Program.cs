using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program is reverse number. Max value contain 9 signs");          
            Console.WriteLine();

            Console.WriteLine("Input value.");           
            var number = Console.ReadLine();

            var reverse = new Reverse(number);
            Console.WriteLine($"\nResult is {reverse.GetReverseNumber()}");

            Console.ReadLine();
        }
    }
}
