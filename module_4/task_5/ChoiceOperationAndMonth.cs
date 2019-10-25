using System;

namespace task_5
{
    class ChoiceOperationAndMonth
    {
        public enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }        

        public enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December        
        }

        public static double MathOperation(double x, double y, Operation op)
        {
            double result = 0.0;

            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    try
                    {
                        if(y == 0)
                        {
                            throw new DivideByZeroException();
                        }

                        result = x / y;
                    }
                    catch(Exception exception) 
                    {
                        Console.WriteLine(exception.Message);                    
                    }
                    break;
            }

            return Math.Round(result, 2);
        }

        public int GetDays(Month month, int year)
        {
            int days = 0;
            switch (month)
            {
                case Month.January:
                    days = 31;
                    break;
                case Month.February:
                    if (year % 4 == 0)
                    {
                        if (year % 100 == 0)
                        {
                            if (year % 400 == 0)
                            {
                                return days = 29;
                            }

                           return days = 28;
                        }

                        days = 29;
                    }
                    else 
                    {
                        days = 28;
                    }

                    break;
                case Month.March:
                    days = 31;
                    break;
                case Month.April:
                    days = 30;
                    break;
                case Month.May:
                    days = 31;
                    break;
                case Month.June:
                    days = 30;
                    break;
                case Month.July:
                    days = 31;
                    break;
                case Month.August:
                    days = 31;
                    break;
                case Month.September:
                    days = 30;
                    break;
                case Month.October:
                    days = 31;
                    break;
                case Month.November:
                    days = 30;
                    break;
                case Month.December:
                    days = 31;
                    break;
                default:
                    break;            
            }

            return days;        
        }
    }
}
