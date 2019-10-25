using System;
using System.Globalization;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Summation summation = new Summation();
            Random random = new Random();

            NumberStyles style =  NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");

            int _length;
            int[] _array;
            int _length1;
            int[] _array1;
            int _sum;
            string _text;
            int _value1;
            int _value2;
            int _value3;

            Console.WriteLine("Choose operation: \n" +
                              "3 integers input 1.\n" +
                              "2 integers input 2.\n" +
                              "3 fractional numbers input 3.\n" +
                              "2 string input 4.\n" +
                              "2 arrays input 5.\n");

            int _choice = int.TryParse(Console.ReadLine(), out int dataFromUser) ? dataFromUser : 0;
            switch (_choice)
            {
                case 1:
                    Console.WriteLine("Input value.");
                    _value1 = int.TryParse(Console.ReadLine(), out int dataFromUser1) ? dataFromUser1 : 0;
                    Console.WriteLine("Input value.");
                    _value2 = int.TryParse(Console.ReadLine(), out int dataFromUser2) ? dataFromUser2 : 0;
                    Console.WriteLine("Input value.");
                    _value3 = int.TryParse(Console.ReadLine(), out int dataFromUser3) ? dataFromUser3 : 0;

                    _sum = summation.Sum(_value1, _value2, _value3);
                    Console.WriteLine($"Result is {_sum}.");
                    break;
                case 2:
                    Console.WriteLine("Input value.");
                    _value1 = int.TryParse(Console.ReadLine(), out dataFromUser1) ? dataFromUser1 : 0;
                    Console.WriteLine("Input value.");
                    _value2 = int.TryParse(Console.ReadLine(), out dataFromUser2) ? dataFromUser2 : 0;

                    _sum = summation.Sum(_value1, _value2);
                    Console.WriteLine($"Result is {_sum}.");
                    break;
                case 3:      
                    Console.WriteLine("Input value.");
                    double _value4 = double.TryParse(Console.ReadLine().Replace(',','.'), style, culture, out double dataFromUser4) ? dataFromUser4 : 0;
                    Console.WriteLine("Input value.");
                    double _value5 = double.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out double dataFromUser5) ? dataFromUser5 : 0;
                    Console.WriteLine("Input value.");
                    double _value6 = double.TryParse(Console.ReadLine().Replace(',', '.'), style, culture, out double dataFromUser6) ? dataFromUser6 : 0;

                    double _result1 = summation.Sum(_value4, _value5, _value6);
                    Console.WriteLine($"Result is {_result1}.");
                    break;
                case 4:
                    Console.WriteLine("Input value.");
                    string _text1 = Console.ReadLine();
                    Console.WriteLine("Input value.");
                    string _text2 = Console.ReadLine();

                    _text = summation.Concat(_text1, _text2);
                    Console.WriteLine($"Result is {_text}.");
                    break;
                case 5:
                    Console.WriteLine("Input length of first array.");

                    summation.VerifyLength(Console.ReadLine(), out _length);
                    _array = new int[_length];
                    for(int index = 0; index < _array.Length; index++)
                    {
                        _array[index] = random.Next(-23, 32);
                    }

                    foreach (var item in _array)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();

                    Console.WriteLine("Input length of second array.");
                    summation.VerifyLength(Console.ReadLine(), out _length1);
                    _array1 = new int[_length1];
                    for (int index = 0; index < _array1.Length; index++)
                    {
                        _array1[index] = random.Next(-65, 12);
                    }

                    foreach (var item in _array1)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine("\n");

                    int[] resultArray = summation.SumArray(_array, _array1);
                    foreach (var item in resultArray)
                    {
                        Console.Write($"{item} ");
                    }
                    break;
                default:
                    Console.WriteLine("Input value.");
                    _value1 = int.TryParse(Console.ReadLine(), out dataFromUser1) ? dataFromUser1 : 0;
                    Console.WriteLine("Input value.");
                    _value2 = int.TryParse(Console.ReadLine(), out dataFromUser2) ? dataFromUser2 : 0;
                    Console.WriteLine("Input value.");
                    _value3 = int.TryParse(Console.ReadLine(), out dataFromUser3) ? dataFromUser3 : 0;

                    _sum = summation.Sum(_value1, _value2, _value3);
                    Console.WriteLine($"Result is {_sum}.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
