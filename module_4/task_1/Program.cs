using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AttributesArray attributesArray = new AttributesArray();
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

            _min = attributesArray.MinElement(_array);
            _max = attributesArray.MaxElement(_array);
            _sum = attributesArray.Sum(_array);
            _difference = attributesArray.DifferenceBetweenMaxAndMin(_array);

            Console.WriteLine();
            Console.WriteLine($"Min element is {_min}");
            Console.WriteLine($"Max element is {_max}");
            Console.WriteLine($"Summa is {_sum}");
            Console.WriteLine($"Difference is {_difference}");

            _array = attributesArray.CreateNewArray(_array);
            foreach (var item in _array)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
    }
}
