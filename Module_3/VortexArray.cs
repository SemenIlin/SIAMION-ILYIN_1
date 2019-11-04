using System;

namespace Module_3
{
    class VortexArray
    {        
        readonly string _textLength;
        private int _length;

        public VortexArray(string length)
        {
            _textLength = length;
        }


        public int[,] CreateVortexArray()
        {
            Verify(_textLength, out _length);
            int[,] vortexArray = new int[_length, _length];

            var left = 0;
            var top = 0;
            var right = _length - 1;
            var bottom = _length - 1;
            var valueArray = 1;

            while (true)
            {
                for (int row = left; row <= right; row++)
                {
                    vortexArray[top, row] = valueArray;
                    valueArray++;
                }

                top++;
                for (int column = top; column <= bottom; column++)
                {
                    vortexArray[column, right] = valueArray;
                    valueArray++;
                }

                right--;  
                for (int row = right; row >= left; row--)
                {
                    vortexArray[bottom, row] = valueArray;
                    valueArray++;
                }

                bottom--;
                for (int column = bottom; column >= top; column--)
                {
                    vortexArray[column, left] = valueArray;
                    valueArray++;
                }

                left++;
                if(_length * _length == valueArray - 1)
                {
                    break;
                }
            }

            return vortexArray;
        }        

        private void Verify(string data, out int value)
        {
            while (!int.TryParse(data, out value) || (value < 0))
            {
                Console.WriteLine("Input value again.");
                data = Console.ReadLine();
            }
        }
    }
}
