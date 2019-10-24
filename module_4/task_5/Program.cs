using System;
     

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Enum @enum = new Enum();

            double _value1;
            double _value2;
            Enum.Operation operation;

            Console.WriteLine("Choose operation: \n" +
                              "Add input 1.\n" +
                              "Substract input 2. \n" +
                              "Multiply input 3.\n" +
                              "Divide input 4.");

            int choice = int.TryParse(Console.ReadLine(), out var dataFromUser) ? dataFromUser : 0;

            switch(choice)
            {
                case 1:
                    operation = Enum.Operation.Add;
                    break;
                case 2:
                    operation = Enum.Operation.Subtract;
                    break;
                case 3:
                    operation = Enum.Operation.Multiply;
                    break;
                case 4:
                    operation = Enum.Operation.Divide;
                    break;
                default:
                    operation = Enum.Operation.Add;
                    break;
            }

            Console.WriteLine("Input first value.");
            _value1 = double.TryParse(Console.ReadLine().Replace('.',','), out double dataFromUser1) ? dataFromUser1 : 0;
            Console.WriteLine("Input second value.");
            _value2 = double.TryParse(Console.ReadLine().Replace('.', ','), out double dataFromUser2) ? dataFromUser2 : 0;
            
            double result = Enum.MathOp(_value1, _value2, operation);
            @enum.Show(result);

            Console.WriteLine();
            Enum.Month month;
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

            _choiceMonth = int.TryParse(Console.ReadLine(), out var dataFromUser3) ? dataFromUser3 : 0;
            switch (_choiceMonth)
            {
                case 1:
                    month = Enum.Month.January;
                    break;
                case 2:
                    month = Enum.Month.February;
                    break;
                case 3:
                    month = Enum.Month.March;
                    break;
                case 4:
                    month = Enum.Month.April;
                    break;
                case 5:
                    month = Enum.Month.May;
                    break;
                case 6:
                    month = Enum.Month.June;
                    break;
                case 7:
                    month = Enum.Month.July;
                    break;
                case 8:
                    month = Enum.Month.August;
                    break;
                case 9:
                    month = Enum.Month.September;
                    break;
                case 10:
                    month = Enum.Month.October;
                    break;
                case 11:
                    month = Enum.Month.November;
                    break;
                case 12:
                    month = Enum.Month.December;
                    break;
                default:
                    month = Enum.Month.January;
                    break;
            }

            Console.WriteLine("\nInput year");
            _year = int.TryParse(Console.ReadLine(), out var dataFromUser4) ? dataFromUser4 : 0;

           @enum.Show(@enum.GetDays(month, _year));

        }

    } 
}