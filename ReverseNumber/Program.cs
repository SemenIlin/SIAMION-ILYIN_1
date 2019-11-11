using System;

namespace ReverseNumber
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("The program is reverse number. Max value contain 9 signs");
            Console.WriteLine();
            Console.WriteLine("Input number.");
            int.TryParse(Console.ReadLine(), out int number);
            var reverse = new ReverseNumber(number);
            
            Console.WriteLine($"After reverse result is {reverse.GetReverseNumber()}.");
            Console.ReadLine();
        }
    }
}