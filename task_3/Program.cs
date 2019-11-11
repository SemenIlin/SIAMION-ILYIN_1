using System;

namespace task_3
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("The program output Fibonacci series. Maximum 140.");   
            Console.WriteLine("Input value.");
            int.TryParse(Console.ReadLine(), out int count);
            var fibonacci = new Fibonacci(count);
            Console.WriteLine();
            foreach (var item in fibonacci)
            {
                Console.Write(item + " ");            
            }

            Console.ReadLine();
        }
    }
}
