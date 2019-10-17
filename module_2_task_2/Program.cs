using System;

namespace module_2_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = new Age();

            var _userAge = 0;

            while (true)
            {

                Console.WriteLine("Input age.");
                age.Verify(Console.ReadLine(), ref _userAge);                

                age.GenerateAnswer(_userAge);

                age.Show();

                Console.WriteLine();
                Console.WriteLine("Continue press Enter, Exit press Esc.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
