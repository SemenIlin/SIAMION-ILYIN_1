using System;

namespace module_2_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var change = new ChangeValue();

            // Declare variables.
            float _value1 = 0F;
            float _value2 = 0F;

            while (true)
            {
                Console.WriteLine("Input first value. ");
                change.Verify(Console.ReadLine(), ref _value1);

                Console.WriteLine("Input second value. ");
                change.Verify(Console.ReadLine(), ref _value2);                

                change.Change(ref _value1, ref _value2);

                change.Show(_value1, _value2);

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
