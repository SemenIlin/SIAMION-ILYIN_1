using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations operation = new Operations();
            Random random = new Random();

            int _length;
            int _min;
            int _max;
            int _sum;
            int _difference;
            int[] _array;

            Console.WriteLine("Input length of array.");
            _length = int.TryParse(Console.ReadLine(), out int dataFromUser) ? dataFromUser : 0;
            _array = new int[_length];

            for (int index = 0; index < _array.Length; index++)
            {
                _array[index] = random.Next(-12, 34);            
            }

            operation.Show<int>(_array);
            _min = operation.MinElement(_array);
            _max = operation.MaxElement(_array);
            _sum = operation.Sum(_array);
            _difference = operation.DifferenceBetweenMaxAndMin(_array);

            Console.WriteLine();
            Console.WriteLine($"Min element is {_min}");
            Console.WriteLine($"Max element is {_max}");
            Console.WriteLine($"Summa is {_sum}");
            Console.WriteLine($"Difference is {_difference}");

            _array = operation.CreateNewArray(_array);
            operation.Show<int>(_array);

            Console.ReadLine();
        }
    }
}
