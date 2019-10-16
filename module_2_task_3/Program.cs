using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_2_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var change = new ChangeValue();

            // Declare variables.
            float value1 = 0F;
            float value2 = 0F;

            while (true)
            {
                change.Input();

                value1 = change.Value1;
                value2 = change.Value2;

                change.Change(ref value1, ref value2);

                change.Show();

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
