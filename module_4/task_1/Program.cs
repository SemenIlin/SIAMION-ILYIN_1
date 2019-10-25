using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int _length;
            int _min;
            int _max;
            int _sum;
            int _difference;
            int[] _array;

            Console.WriteLine("Input length of array.");
            _length = int.TryParse(Console.ReadLine(), out int dataFromUser) ? (dataFromUser < 0 ? Math.Abs(dataFromUser) : dataFromUser) : 0;
            _array = new int[_length];

            for (int index = 0; index < _array.Length; index++)
            {
                _array[index] = random.Next(-12, 34);            
            }

            foreach (var item in _array)
            {
                Console.Write($"{item} ");
            }

            _min = _array.MaxElement();
            _max = _array.MaxElement();
            _sum = _array.Sum();
            int _min1 = _array.MinElementUsingFunc();
            int _max1 = _array.MaxElementUsingFunc();
            int _sum1 = _array.SumUsingFunc();
            _difference = _array.DifferenceBetweenMaxAndMin();

            Console.WriteLine();
            Console.WriteLine($"Min element is {_min}");
            Console.WriteLine($"Min element is {_min1} (UsingFunc)");
            Console.WriteLine($"Max element is {_max}");
            Console.WriteLine($"Max element is {_max1} (UsingFunc)");
            Console.WriteLine($"Summa is {_sum}");
            Console.WriteLine($"Summa is {_sum1} (UsingFunc)");
            Console.WriteLine($"Difference is {_difference}");

            _array = _array.CreateNewArray();
            foreach (var item in _array)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
