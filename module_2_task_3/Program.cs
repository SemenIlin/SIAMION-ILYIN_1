using System;
using System.Globalization;

namespace module_2_task_3
{
    class Program
    {
        static void Main()
        {
            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            
            Console.WriteLine("Input first value.");
            float.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out float value1);
            Console.WriteLine("Input second value. ");
            float.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out float value2);
            var change = new Change(value1, value2);

            Console.WriteLine($"First value is {change.GetFirstValue()} , second value is {change.GetSecondValue()}");
            Console.ReadLine();
        }
    }
}
