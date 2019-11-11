using System;

namespace task_5
{
    class TypeOperation
    {
        public enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }                

        public static double MathOperation(double x, double y, Operation op)
        {
            double result = 0.0;

            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    if(y == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    result = x / y;
                    break;
            }

            return Math.Round(result, 2);
        }
    }
}
