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

            if ((int.TryParse(Console.ReadLine(), out _length)) && (_length > 0))
            {
                _array = new int[_length];
                for (int index = 0; index < _length; index++)
                {
                    _array[index] = random.Next(-30, 59);
                }

                foreach (var item in _array)
                {
                    Console.Write($"{item} ");
                }

                array.IncreaseValuesOfArray(_array);
                Console.WriteLine();
                foreach (var item in _array)
                {
                    Console.Write($"{item} ");
                }
            }
            else 
            {
                Console.WriteLine("Invalid data.");            
            }
        }
    }
}
