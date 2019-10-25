using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            Random random = new Random();

            int _length;
            int _choice;
            Array.Direction direction;
            int[] _array;

            Console.WriteLine("Input length of array.");
            _length = int.TryParse(Console.ReadLine(), out int dataFromUser) ? (dataFromUser < 0 ? Math.Abs(dataFromUser) : dataFromUser): 0;
            _array = new int[_length];

            for (int index = 0; index < _array.Length; index++)
            {
                _array[index] = random.Next(-36, 52);            
            }

            Console.WriteLine("Choose direction: \n" +
                              "Decrease input 1. \n" +
                              "Increase input 2.\n");

            if ((int.TryParse(Console.ReadLine(), out _choice)) && (_choice > 0) && (_choice < 3))
            {
                direction = (Array.Direction)_choice;

                foreach (var value in _array)
                {
                    Console.Write($"{value} ");
                }
                _array = array.Sort(direction, _array);
                Console.WriteLine();

                foreach (var value in _array)
                {
                    Console.Write($"{value} ");
                }
            }
        }
    }
}
