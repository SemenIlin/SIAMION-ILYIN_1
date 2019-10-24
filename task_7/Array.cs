using System;
using System.Collections.Generic;

namespace task_7
{
    class Array
    {
        Random random = new Random();
        readonly string _textLength;
        private int _length;
        private int[] _array;

        public Array(string length)
        {
            _textLength = length;
            Verify(_textLength, out _length);
            _array = new int[_length];

            for (int index = 0; index < _array.Length; index++)
            {
                _array[index] = random.Next(-36, 69);
            }
        }

        public int[] GetArray()
        {
            return _array;
        }

        private void Verify(string data, out int value)
        {
            while (!int.TryParse(data, out value) || (value < 0))
            {
                Console.WriteLine("Input value again.");

                data = Console.ReadLine();
            }
        }

        public List<int> GetSpecialValue(int[] array)
        {
            var result = new List<int>();
            for(int index = 1; index < array.Length; index++)
            {
                if (array[index] > array[index - 1])
                {
                    result.Add(array[index]);
                }
            }

            return result;
        }
    }
}
