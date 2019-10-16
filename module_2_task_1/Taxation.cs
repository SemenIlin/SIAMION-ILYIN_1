using System;

namespace module_2_task_1
{
    class Taxation
    {
        const int income = 500;

        int countCompanies = 0;
        float taxPerCent = 0.0F;
        float totalFix = 0.0F;        

        // Input data from user.
        public void Input()
        {
            Console.WriteLine("Input count companies.");

            Verify(Console.ReadLine(), ref countCompanies);

            Console.WriteLine("Input size tax in per cent.");

            Verify(Console.ReadLine(), ref taxPerCent);
        }

        string OutputErrorMessage(string data)
        {
            char [] tempArray = data.ToCharArray();

            int countPoint = 0;
            int countSign = 0;

            foreach (char ch in tempArray)
            {
                if (Char.IsNumber(ch))
                {
                    continue;
                }

                else if( ch == '.')
                {
                    countPoint++;

                    if(countPoint > 1)
                    {
                       return "Incorrect data.";
                    }
                }

                else if (ch == '-')
                {
                    countSign++;

                    if (countSign > 1)
                    {
                        return "Incorrect data.";
                    }
                }

                else
                {
                    return "Incorrect data.";
                }
            }

            if((countSign == 1) && (countPoint == 0))
            {
                return "Input data < 0.";
            }

            else if((countSign == 0) && (countPoint == 1))
            {
                return "Input data include '.' in place ','.";
            }

            else if((countSign == 1) && (countPoint == 1))
            {
                return "Input data < 0. " + "Input data include '.' in place ','.";
            }

            return "Incorrect data.";
        }        

        void Verify(string data, ref int value)
        {
            while ((!int.TryParse(data, out value)) || (value < 0))
            {
                Console.WriteLine(OutputErrorMessage(data));

                Console.WriteLine("Input value again.");

                data = Console.ReadLine();
            }
        }

        void Verify(string data, ref float value)
        {

            while ((!float.TryParse(data, out value)) || (value < 0))
            {
                Console.WriteLine(OutputErrorMessage(data));
                Console.WriteLine("Input value again.");

                data = Console.ReadLine();
            }
        }

        // Count companies. 
        public int Count { get { return countCompanies; } }

        // Tax is value per cent.
        public float Tax { get { return taxPerCent; } }

        public float TotalTax { get { return totalFix; } }

        public float CalculateTotalTax(int countCompanies, float tax)
        {
            totalFix = (float)countCompanies * income * tax / 100;

            return totalFix;
        }
        
        public void Show()
        {
            Console.WriteLine($"The total amount of tax = {totalFix}.");
        }
    }
}
