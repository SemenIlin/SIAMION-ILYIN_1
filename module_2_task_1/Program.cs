using System;

namespace module_2_task_1
{
    public class Program
    {
        static void Main()
        {
            int countCompanies;
            float perCent;
            float totalFix;
            try
            {
                Console.WriteLine("Input count companies.");
                countCompanies = int.TryParse(Console.ReadLine(), out countCompanies) ?
                    (countCompanies > 0 ? countCompanies : throw new Exception("Еhe value must be greater 0 ")) :
                    throw new InvalidCastException();

                Console.WriteLine("Input size tax in per cent.");
                perCent = float.TryParse(Console.ReadLine(), out perCent) ? 
                    (perCent > 0 ? perCent : throw new Exception("Еhe value must be greater 0 ")) :
                    throw new InvalidCastException();

                var taxation = new Taxation(countCompanies, perCent);

                totalFix = taxation.CalculateTotalTax();
                taxation.Show();
            }
            catch (InvalidCastException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
    }
}