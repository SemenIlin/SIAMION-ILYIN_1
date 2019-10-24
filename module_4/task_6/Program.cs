using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Array array = new Array();

            int _length;
            int[] _array;
            Console.WriteLine("Input length of array.");

            _length = int.TryParse(Console.ReadLine(), out int dataFromUser) ? dataFromUser : 0;
            _array = new int[_length];
            for (int index = 0; index < _length; index++)
            {
                _array[index] = random.Next(-30, 59);
            }

            array.Show<int>(_array);
            array.IncreaseValuesOfArray(_array);
            Console.WriteLine();
            array.Show<int>(_array);
        }
    }
}
