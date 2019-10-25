using System;
using System.Globalization;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            RefAndOut refAndOut = new RefAndOut();
            Random random = new Random();
            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");

            int _length;
            int[] _array;
            int _sum;
            int _min;
            int _max;
            double _value1;
            double _value2;
            double _value3;
            double _radius;
            double _perimeter;
            double _square;

            Console.WriteLine("Choose operation: \n" +
                             "Increase the value of the three input variables by 10 input 1.\n" +
                             "Find the length of the circle and the area of the circle input 2.\n" +
                             "Find the minimum and maximum array element and the sum of all array elements input 3.\n");

            int choice = int.TryParse(Console.ReadLine(), out int dataFromUser) ? dataFromUser : 0;
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Input value.");
                    _value1 = double.TryParse(Console.ReadLine().Replace(',','.'), style, culture, out double dataFromUser1) ? dataFromUser1 : 0;
                    Console.WriteLine("Input value.");
                    _value2 = double.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out double dataFromUser2) ? dataFromUser2 : 0;
                    Console.WriteLine("Input value.");
                    _value3 = double.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out double dataFromUser3) ? dataFromUser3 : 0;

                    refAndOut.IncreaseNumbers(ref _value1, ref _value2, ref _value3);
                    Console.WriteLine($"value1 = {_value1}, value2 = {_value2}, value3 = {_value3}");
                    break;
                case 2:
                    Console.WriteLine("Input radius.");
                    refAndOut.VerifyRadius(Console.ReadLine().Replace(',', '.'), style, culture, out _radius);
                    refAndOut.GetLengthAndSquareCircle(_radius,out _perimeter, out _square);
                    Console.WriteLine($"length = {_perimeter}, square = {_square}");
                    break;
                case 3:
                    Console.WriteLine("Input length of array");
                    try
                    {
                        if (int.TryParse(Console.ReadLine(), out _length))
                        {
                            _array = new int[_length];
                            for (int index = 0; index < _array.Length; index++)
                            {
                                _array[index] = random.Next(-54, 36);
                            }

                            foreach (var item in _array)
                            {
                                Console.Write($"{item} ");
                            }

                            Console.WriteLine();
                            refAndOut.GetMinMaxAndSum(_array, out _min, out _max, out _sum);
                            refAndOut.GetMinMaxAndSumUsingFunc(_array, out int _min1, out int _max1, out int _sum1);
                            Console.WriteLine($"min = {_min}, max = {_max}, sum = {_sum}");
                            Console.WriteLine($"min = {_min1}, max = {_max1}, sum = {_sum1}");
                        }
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception.Message);                    
                    }
                    break;
                default:
                    Console.WriteLine("Input value.");
                    _value1 = double.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out dataFromUser1) ? dataFromUser1 : 0;
                    Console.WriteLine("Input value.");
                    _value2 = double.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out dataFromUser2) ? dataFromUser2 : 0;
                    Console.WriteLine("Input value.");
                    _value3 = double.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out dataFromUser3) ? dataFromUser3 : 0;

                    refAndOut.IncreaseNumbers(ref _value1, ref _value2, ref _value3);
                    Console.WriteLine($"value1 = {_value1}, value2 = {_value2}, value3 = {_value3}");

                    break;
            }

            Console.ReadLine();
        }
    }
}
