using System;

namespace module_2_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = new Age();

            int userAge;

            while (true)
            {

                age.Input();

                userAge = age.UserAge;

                age.GenerateAnswer(userAge);

                age.Show();

                Console.WriteLine();
                Console.WriteLine("Continue press Enter, Exit press Esc.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
