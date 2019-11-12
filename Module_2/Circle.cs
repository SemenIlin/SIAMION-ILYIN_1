using System;

namespace Module_2
{
    public class Circle
    {
        private readonly double square;
        private readonly double perimeter;

        public Circle(double radius)
        {
            square = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            perimeter = Math.Round(Math.PI * radius * 2, 2);
        }

        public double GetSquare()
        {
            return square;
        }

        public double GetPerimeter()
        {
            return perimeter;
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
