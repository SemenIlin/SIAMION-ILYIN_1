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
            _length = int.TryParse(Console.ReadLine(), out int dataFromUser) ? dataFromUser : 0;
            _array = new int[_length];

            for (int index = 0; index < _array.Length; index++)
            {
                _array[index] = random.Next(-36, 52);            
            }

            Console.WriteLine("Choose direction: \n" +
                              "Decrease input 1. \n" +
                              "Increase input 2.\n");

            _choice = int.TryParse(Console.ReadLine(), out int dataFromUser2) ? dataFromUser2 : 0;
            switch (_choice) 
            {
                case 1:
                    direction = Array.Direction.Decrease;
                    break;
                case 2:
                    direction = Array.Direction.Increase;
                    break;
                default:
                    direction = Array.Direction.Increase;
                    break;
            }

            array.Show<int>(_array);
            _array = array.Sort(direction, _array);
            Console.WriteLine();
            array.Show<int>(_array);
        }
    }
}
