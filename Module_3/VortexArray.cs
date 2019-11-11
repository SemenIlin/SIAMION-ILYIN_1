using System;

namespace Module_3
{
    class VortexArray
    {
        private readonly int[,] vortexArray;

        public VortexArray(int value)
        {
            vortexArray = new int[value, value];

            var left = 0;
            var top = 0;
            var right = value - 1;
            var bottom = value - 1;
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
                if (value * value == valueArray - 1)
                {
                    break;
                }
            }
        }

        public int[,] GetVortexArray()
        {
            return vortexArray;
        }
    }
}
