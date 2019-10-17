using System;

namespace module_2_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxation = new Taxation();

            var _countCompanies = 0;
            var _tax = 0.0F;
            var _totalFix = 0.0F;

            while (true)
            {
                Console.WriteLine("Input count companies.");
                taxation.Verify(Console.ReadLine(), ref _countCompanies);

                Console.WriteLine("Input size tax in per cent.");
                taxation.Verify(Console.ReadLine(), ref _tax);

                _totalFix = taxation.CalculateTotalTax(_countCompanies, _tax);
                taxation.Show(_totalFix);

                Console.WriteLine();
                Console.WriteLine("Continue press Enter, Exit press Esc. ");

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
