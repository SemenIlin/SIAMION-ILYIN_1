using System;

namespace module_2_task_1
{
    class Taxation
    {
        private const int _income = 500;

        private string OutputErrorMessage(string data)
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

        public void Verify(string data, ref int value)
        {
            while ((!int.TryParse(data, out value)) || (value < 0))
            {
                Console.WriteLine(OutputErrorMessage(data));
                Console.WriteLine("Input value again.");

                data = Console.ReadLine();
            }
        }

        public void Verify(string data, ref float value)
        {
            while ((!float.TryParse(data, out value)) || (value < 0) || (value > 100))
            {
                Console.WriteLine(OutputErrorMessage(data));
                Console.WriteLine("Input value again.");

                data = Console.ReadLine();
            }
        }
        
        public float CalculateTotalTax(int countCompanies, float tax)
        {
            return (float)countCompanies * _income * tax / 100;
        }
        
        public void Show(float totalFix)
        {
            Console.WriteLine($"The total amount of tax = {totalFix}.");
        }
    }
}
