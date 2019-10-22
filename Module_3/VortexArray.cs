﻿using System;

namespace Module_3
{
    class VortexArray
    {
        private const string format = "{0,5}";

        public int[,] CreateVortexArray(int value)
        {
            int[,] vortexArray = new int[value, value];

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
                if(value * value == valueArray - 1)
                {
                    break;
                }
            }

            return vortexArray;
        }

        public void Show(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(format, array[i, j]);
                }

                Console.WriteLine();
            }
        }

        public void Verify(string data, ref int value)
        {
            while (!int.TryParse(data, out value))
            {
                Console.WriteLine("Input value again.");
                data = Console.ReadLine();
            }
        }
    }
}
