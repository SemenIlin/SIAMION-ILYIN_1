using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int _length;
            int _choice;
            OperationWithArray.Direction direction;
            int[] _array;
            int[] _array1;

            Console.WriteLine("Input length of array.");
            _length = int.TryParse(Console.ReadLine(), out int dataFromUser) ? (dataFromUser < 0 ? Math.Abs(dataFromUser) : dataFromUser): 0;
            _array = new int[_length];
            _array1 = new int[_length];

            for (int index = 0; index < _array.Length; index++)
            {
                _array[index] = random.Next(-36, 52);
                _array1[index] = _array[index];
            }

            Console.WriteLine("Choose direction: \n" +
                              "Decrease input 1. \n" +
                              "Increase input 2.\n");

            if ((int.TryParse(Console.ReadLine(), out _choice)) && (_choice > 0) && (_choice < 3))
            {
                direction = (OperationWithArray.Direction)_choice;

                foreach (var value in _array)
                {
                    Console.Write($"{value} ");
                }

                _array = _array.SortUsingFunc(direction);

                Console.WriteLine();
                foreach (var value in _array)
                {
                    Console.Write($"{value} ");
                }

                Console.WriteLine();
                Console.WriteLine();
                foreach (var value in _array1)
                {
                    Console.Write($"{value} ");
                }

                Console.WriteLine();
                _array1 = _array1.Sort(direction);
                foreach (var value in _array1)
                {
                    Console.Write($"{value} ");
                }
            }
        }
    }
}
