using System;

namespace Module_2
{
    class Circle: ICalculate
    {  
        private double _radius;

        private double CalculateCircleSquare(double radius)

        {
            double square = 0.0;

            square = Math.PI * Math.Pow(radius, 2) ;

            return Math.Round(square, 2);
        }

        private double CalculateCirclePerimeter(double radius)

        {
            double perimeter = 0;

            perimeter = Math.PI * radius * 2;

            return Math.Round(perimeter, 2);
        }
        
        private void InputRadius()

        {
            Console.WriteLine("Input the radius, please");

            while (true)
            {

                if ((double.TryParse(Console.ReadLine(), out _radius)) && (_radius > 0))

                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        public void InputData(int operation, int formula = 1)
        {
            if (operation == 1)
            {
                InputRadius();
            }

            else if (operation == 2)
            {
                InputRadius();
            }
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
            _radius = 0.0;

            _radius = perimeter /(2 * Math.PI);

            return Math.Round(_radius, 2);
        }

        public double GetParameterFromSquare(double square)
        {
            _radius = 0.0;

            _radius = Math.Pow((square / Math.PI), 0.5);

            return Math.Round(_radius, 2);
        }
    }
}
