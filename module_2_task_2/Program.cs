using System;

namespace module_2_task_2
{
    class Program
    {
        static void Main()
        {
            var age = new Age();
            Console.WriteLine("Input age.");
            int.TryParse(Console.ReadLine(), out int userAge);            
            age.GenerateAnswer(userAge);
            age.Show();            

            Console.ReadLine();
        }
    }
}
