using System;

namespace task_2
{
    class EvenNumbers
    {
        readonly string _textCount;
        private int _count;
        public EvenNumbers(string count)
        {
            _textCount = count;       
        }

        private void Verify(string data, out int value)
        {
            while ((!int.TryParse(data, out value)) || (value < 0))
            {
                Console.WriteLine("Incorrect data, input value again, please.");

                data = Console.ReadLine();
            }
        }

        public int[] GetNumbersFibonacci()
        {
            Verify(_textCount, out _count);
            int[] array = new int[_count]; 
            for (int index = 2, index1 = 0; index <= _count * 2; index += 2, index1++)
            {
                array[index1] = index;
            }

            return array;
        }
    }
}
