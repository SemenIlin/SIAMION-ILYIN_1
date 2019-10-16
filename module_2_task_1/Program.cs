using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_2_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxation = new Taxation();

            int countCompanies;
            float tax;

            while (true)
            {
                taxation.Input();

                countCompanies = taxation.Count;
                tax = taxation.Tax;

                taxation.CalculateTotalTax(countCompanies, tax);

                taxation.Show();

                Console.WriteLine();
                Console.WriteLine("Continue press Enter, Exit press Esc. ");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
