using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    class GetDataFromUser
    {        
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;
        private double _fourthSide;

        private double _height;
        private double _width;

        private int _firstAngle;
        private int _secondAngle;

        private double _radius;

        // Data from method calculate(typeOperation, formula).
        private double _result;

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

        private void InputWidth()
        {
            Console.WriteLine("Input a width, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out _width)) && (_width > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        private void InputHeight()
        {
            Console.WriteLine("Input a height, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out _height)) && (_height > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data. repeat again please.");
                }
            }
        }

        private void InputFirstSide()
        {
            Console.WriteLine("Input the first side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out _firstSide)) && (_firstSide > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        private void InputSecondSide()
        {
            Console.WriteLine("Input the second side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out _secondSide)) && (_secondSide > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        private void InputThirdSide()
        {
            Console.WriteLine("Input the third side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out _thirdSide)) && (_thirdSide > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        private void InputFourthSide()
        {
            Console.WriteLine("Input the fourth side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out _fourthSide)) && (_fourthSide > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        private void InputFirstAngle()
        {
            Console.WriteLine("Input the first angle, please");

            while (true)
            {
                if ((int.TryParse(Console.ReadLine(), out _firstAngle)) && (_firstAngle > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        private void InputSecondAngle()
        {
            Console.WriteLine("Input the second angle, please");

            while (true)
            {
                if ((int.TryParse(Console.ReadLine(), out _secondAngle)) && (_secondAngle > 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        public void InputDataTriangle(int operation, int formula, ref Triangle triangle)
        {
            if (operation == 1)
            {
                switch (formula)
                {
                    case 1:
                        InputHeight();
                        InputWidth();

                        triangle = new Triangle(_height, _width);

                        break;

                    case 2:
                        InputFirstSide();
                        InputSecondSide();
                        InputThirdSide();

                        triangle = new Triangle(_firstSide, _secondSide, _thirdSide);

                        break;

                    case 3:
                        InputFirstSide();
                        InputSecondSide();
                        InputFirstAngle();

                        triangle = new Triangle(_firstSide, _secondSide, _firstAngle);

                        break;

                    case 4:
                        InputFirstSide();
                        InputFirstAngle();
                        InputSecondAngle();

                        triangle = new Triangle(_firstSide, _firstAngle, _secondAngle);

                        break;

                    default:
                        break;
                }
            }

            else if (operation == 2)
            {
                switch (formula)
                {
                    case 1:
                        InputFirstSide();
                        InputSecondSide();
                        InputThirdSide();

                        triangle = new Triangle(_firstSide, _secondSide, _thirdSide);

                        break;

                    case 2:
                        InputFirstSide();
                        InputSecondSide();
                        InputFirstAngle();

                        triangle = new Triangle(_firstSide, _secondSide, _firstAngle);

                        break;

                    case 3:
                        InputFirstSide();
                        InputFirstAngle();
                        InputSecondAngle();

                        triangle = new Triangle(_firstSide, _firstAngle, _secondAngle);

                        break;

                    default:
                        break;
                }
            }
        }

        public void InputDataQuadrangle(int operation, int formula, ref Quadrangle quadrangle)
        {
            if (operation == 1)
            {
                switch (formula)
                {
                    case 1:
                        InputFirstSide();

                        quadrangle = new Quadrangle(_firstSide);

                        break;

                    case 2:
                        InputHeight();
                        InputWidth();

                        quadrangle = new Quadrangle(_height, _width);

                        break;

                    case 3:
                        InputFirstSide();
                        InputSecondSide();
                        InputThirdSide();
                        InputFourthSide();

                        quadrangle = new Quadrangle(_firstSide, _secondSide, _thirdSide, _fourthSide);

                        break;

                    default:
                        break;
                }
            }

            else if (operation == 2)
            {
                switch (formula)
                {

                    case 1:
                        InputFirstSide();

                        quadrangle = new Quadrangle(_firstSide);

                        break;

                    case 2:
                        InputHeight();
                        InputWidth();

                        quadrangle = new Quadrangle(_height, _width);

                        break;

                    case 3:
                        InputFirstSide();
                        InputSecondSide();
                        InputThirdSide();
                        InputFourthSide();

                        quadrangle = new Quadrangle(_firstSide, _secondSide, _thirdSide, _fourthSide);

                        break;

                    default:
                        break;
                }
            }
        }

        public void InputDataRadius(int operation, ref Circle circle, int formula = 1)
        {
            if (operation == 1)
            {
                InputRadius();
                circle = new Circle(_radius);
            }
            else if (operation == 2)
            {
                InputRadius();
                circle = new Circle(_radius);
            }
        }

        public void Calculate(ICalculate calculate, int typeOperation, int formula)
        {
            _result = calculate.Calculate(typeOperation, formula);
        }

        public void Show(int shape,int operation, string txtShape, string txtOperation, string txtFormula, Circle circle, Triangle triangle, Quadrangle quadrangle)
        {
            var additionalShape = "";

            switch (shape)
            {
                case 1:
                    if (operation == 1)
                    {
                        _firstSide = triangle.GetParameterFromSquare(_result);
                        _secondSide = quadrangle.GetParameterFromSquare(_result);

                        additionalShape = $"Triangle with side {_firstSide} and quadrangle with side {_secondSide} have the same area";
                    }
                    else if (operation == 2)
                    {
                        _firstSide = triangle.GetParameterFromPerimeter(_result);
                        _secondSide = quadrangle.GetParameterFromPerimeter(_result);

                        additionalShape = $"Triangle with side {_firstSide} and quadrangle with side {_secondSide} have the same perimeter";
                    }

                    break;

                case 2:
                    if (operation == 1)
                    {
                        _radius = circle.GetParameterFromSquare(_result);
                        _secondSide = quadrangle.GetParameterFromSquare(_result);

                        additionalShape = $"Circle with radius {_radius} and quadrangle with side {_secondSide} have the same area";
                    }
                    else if (operation == 2)
                    {
                        _radius = circle.GetParameterFromPerimeter(_result);
                        _secondSide = quadrangle.GetParameterFromPerimeter(_result);

                        additionalShape = $"Circle with radius {_radius} and quadrangle with side {_secondSide} have the same perimeter";
                    }

                    break;

                case 3:
                    if (operation == 1)
                    {
                        _radius = circle.GetParameterFromSquare(_result);
                        _firstSide = triangle.GetParameterFromSquare(_result);

                        additionalShape = $"Circle with radius {_radius} and triangle with side {_firstSide} have the same area";
                    }
                    else if (operation == 2)
                    {
                        _radius = circle.GetParameterFromPerimeter(_result);
                        _firstSide = triangle.GetParameterFromPerimeter(_result);

                        additionalShape = $"Circle with radius {_radius} and triangle with side {_firstSide} have the same perimeter";
                    }

                    break;
            }

            Console.WriteLine($"Shape: {txtShape}.\n" +
                              $"Operation: {txtOperation}.\n" +
                              $"Datas: {txtFormula}. \n" +
                              $"{txtOperation} is {_result} \n" +
                              additionalShape);
        }
    }
}
