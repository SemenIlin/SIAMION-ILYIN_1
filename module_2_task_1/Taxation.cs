using System;

namespace module_2_task_1
{
    public class Taxation
    {
        private const int COMPANY_INCOME = 500;
        private readonly int countCompanies;
        private readonly float tax;
        private float totalTax;

        public Taxation(int countCompanies, float tax)
        {
            this.countCompanies = countCompanies;
            this.tax = tax;
        }

        public float CalculateTotalTax()
        {
            totalTax = (float)countCompanies * COMPANY_INCOME * tax / 100;
            return totalTax;
        }
        
        public void Show()
        {
            Console.WriteLine($"The total amount of tax = {totalTax}.");
        }
    }
}
