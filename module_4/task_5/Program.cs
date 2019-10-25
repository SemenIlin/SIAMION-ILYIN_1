using System;
using System.Globalization;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var choiceOperationAndMonth = new ChoiceOperationAndMonth();

            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");

            double _value1;
            double _value2;
            int _choice;
            ChoiceOperationAndMonth.Operation operation;

            Console.WriteLine("Choose operation: \n" +
                              "Add input 1.\n" +
                              "Substract input 2. \n" +
                              "Multiply input 3.\n" +
                              "Divide input 4.");

            if ((int.TryParse(Console.ReadLine(), out _choice)) && (_choice > 0) && (_choice < 5))
            {
                operation = (ChoiceOperationAndMonth.Operation)_choice;

                Console.WriteLine("Input first value.");
                _value1 = double.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out double dataFromUser1) ? dataFromUser1 : 0;
                Console.WriteLine("Input second value.");
                _value2 = double.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out double dataFromUser2) ? dataFromUser2 : 0;

                double result = ChoiceOperationAndMonth.MathOperation(_value1, _value2, operation);
                Console.WriteLine($"Result is {result}.");
            }
            else 
            {
                Console.WriteLine("Invalid data.");            
            }

            Console.WriteLine();
            ChoiceOperationAndMonth.Month month;
            int _year;
            int _choiceMonth;

            Console.WriteLine("Selected month: \n" +
                              "January input 1.\n" +
                              "February input 2. \n" +
                              "March input 3.\n" +
                              "April input 4.\n" +
                              "May input 5.\n" +
                              "June input 6.\n" +
                              "July input 7.\n" +
                              "August input 8.\n" +
                              "September input 9.\n" +
                              "October input 10. \n" +
                              "November input 11.\n" +
                              "December input 12." );

            if ((int.TryParse(Console.ReadLine(), out _choiceMonth)) && (_choiceMonth > 0) && (_choiceMonth < 13))
            {
                month = (ChoiceOperationAndMonth.Month)_choiceMonth;

                Console.WriteLine("\nInput year");
                _year = int.TryParse(Console.ReadLine(), out var dataFromUser4) ? dataFromUser4 : 0;

                Console.WriteLine($"Result is {choiceOperationAndMonth.GetDays(month, _year)}.");
            }
            else
            {
                Console.WriteLine("Invalid data.");
            }
        }
    } 
}