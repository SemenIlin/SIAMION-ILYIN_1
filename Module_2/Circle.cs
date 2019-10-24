using System;

namespace Module_2
{
    class Circle : ICalculate
    {
        private double _radius;

        public Circle() { }

        public Circle(double radius)
        {
            _radius = radius;
        }

        private double CalculateCircleSquare(double radius)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        private double CalculateCirclePerimeter(double radius)
        {
            return Math.Round(Math.PI * radius * 2, 2);
        }

        public double Calculate(int operation, int formula = 1)
        {
            if (operation == 1)
            {
                return CalculateCircleSquare(_radius);
            }
            else 
            {
                return CalculateCirclePerimeter(_radius);
            }
        }

        public double GetParameterFromPerimeter(double perimeter)
        {
            return Math.Round(perimeter / (2 * Math.PI), 2);
        }

        public double GetParameterFromSquare(double square)
        {
            return Math.Round(Math.Pow((square / Math.PI), 0.5), 2);
        }
    }
}
