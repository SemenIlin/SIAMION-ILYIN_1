using System;

namespace task_6
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

        public int[] GetOppositeValueArray(int[] array) 
        {
            for(int index = 0; index < array.Length; index++)
            {
                array[index] = -array[index]; 
            }

            return array;
        }       
    }
}
