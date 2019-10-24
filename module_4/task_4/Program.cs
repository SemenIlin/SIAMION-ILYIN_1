using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple tuple = new Tuple();
            Random random = new Random();

            int _length;
            int[] _array;
            int _sum;
            int _min;
            int _max;
            double _value1;
            double _value2;
            double _value3;
            double _perimeter;
            double _square;

            Console.WriteLine("Choose operation: \n" +
                             "Increase the value of the three input variables by 10 input 1.\n" +
                             "Find the length of the circle and the area of the circle input 2.\n" +
                             "Find the minimum and maximum array element and the sum of all array elements input 3.\n");

            int choice = int.TryParse(Console.ReadLine(), out int dataFromUser) ? dataFromUser : 0;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Input value.");
                    _value1 = double.TryParse(Console.ReadLine().Replace('.', ','), out double dataFromUser1) ? dataFromUser1 : 0;
                    Console.WriteLine("Input value.");
                    _value2 = double.TryParse(Console.ReadLine().Replace('.', ','), out double dataFromUser2) ? dataFromUser2 : 0;
                    Console.WriteLine("Input value.");
                    _value3 = double.TryParse(Console.ReadLine().Replace('.', ','), out double dataFromUser3) ? dataFromUser3 : 0;

                    var result = tuple.GetIncreaseNumbers(_value1, _value2, _value3);
                    Console.WriteLine($"value1 = {result.Value1}, value2 = {result.Value2}, value3 = {result.Value3}.");

                    break;
                case 2:
                    Console.WriteLine("Input radius.");
                    double _radius = double.TryParse(Console.ReadLine().Replace('.', ','), out double dataFromUser4) ? dataFromUser4 : 0;

                    var result1 = tuple.GetLengthAndSquareCircle(_radius);
                    Console.WriteLine($"length = {result1.Length}, square = {result1.Square}.");
                    break;
                case 3:
                    Console.WriteLine("Input length of array");
                    _length = int.TryParse(Console.ReadLine(), out int dataFromuser5) ? dataFromuser5 : 0;
                    _array = new int[_length];

                    for (int index = 0; index < _array.Length; index++)
                    {
                        _array[index] = random.Next(-54, 36);
                    }

                    tuple.Show<int>(_array);
                    Console.WriteLine();

                    var result2 = tuple.GetMinMaxAndSum(_array);
                    Console.WriteLine($"min = {result2.Min}, max = {result2.Max}, sum = {result2.Sum}.");                    
                    break;
                default:
                    Console.WriteLine("Input value.");
                    _value1 = double.TryParse(Console.ReadLine().Replace('.', ','), out  dataFromUser1) ? dataFromUser1 : 0;
                    Console.WriteLine("Input value.");
                    _value2 = double.TryParse(Console.ReadLine().Replace('.', ','), out  dataFromUser2) ? dataFromUser2 : 0;
                    Console.WriteLine("Input value.");
                    _value3 = double.TryParse(Console.ReadLine().Replace('.', ','), out  dataFromUser3) ? dataFromUser3 : 0;

                    result = tuple.GetIncreaseNumbers(_value1, _value2, _value3);
                    Console.WriteLine($"value1 = {result.Value1}, value2 = {result.Value2}, value3 = {result.Value3}.");

                    break;
            }

            Console.ReadLine();        

        }
    }
}
