using System;

namespace Module_2
{
    class Triangle : ICalculate
    {
        private double _height;       
        private double _width;
       
        private int _firstAngle; 
        private int _secondAngle;        
       
        private double _firstSideTriangle;
        private double _secondSideTriangle;       
        private double _thirdSideTriangle;

        bool _isExistsTriangle;

        private double ConvertAngle(double angle)
        {
            return angle * Math.PI / 180;
        }

        private double CalculateTriangleSquare(double height, double width)
        {
            double square = 0.0;

            square = height * width / 2;

            return Math.Round(square, 2);
        }

        private double CalculateTriangleSquare(double firstSide, double secondSide, double thirdSide)
        {
            double halfPerimetr = 0;
            double square = 0.0;

            halfPerimetr = (firstSide + secondSide + thirdSide) / 2;
            square = Math.Pow((halfPerimetr * (halfPerimetr - firstSide) * (halfPerimetr - secondSide) * (halfPerimetr - thirdSide)), 0.5);

            return Math.Round(square, 2);
        }

        private double CalculateTriangleSquare(double firstSide, double secondSide, int angle)
        {
            double square = 0.0;

            square = (firstSide * secondSide * Math.Sin(ConvertAngle(angle)) / 2);

            return Math.Round(square, 2);
        }

        private double CalculateTriangleSquare(double side, int firstAngle, int secondAngle)
        {
            double square = 0.0;

            square = Math.Pow(side, 2) * Math.Sin(ConvertAngle(firstAngle)) * Math.Sin(ConvertAngle(secondAngle)) / (Math.Sin(ConvertAngle(180 - firstAngle - secondAngle)) * 2);

            return Math.Round(square, 2);
        }

        private double CalculateTrianglePerimeter(double firstSide, double secondSide, double thirdSide)
        {
            double perimeter = 0;

            perimeter = firstSide + secondSide + thirdSide;

            return Math.Round(perimeter, 2);
        }

        private double CalculateTrianglePerimeter(double firstSide, double secondSide, int angleBetweenSide)
        {
            double perimeter;
            double thirdSide;

            thirdSide = Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2) - 2 * firstSide * secondSide * Math.Cos(ConvertAngle(angleBetweenSide)));

            perimeter = firstSide + secondSide + thirdSide;

            return Math.Round(perimeter, 2);
        }

        private double CalculateTrianglePerimeter(double side, int firstAngle, int secondAngle)
        {
            double perimeter;
            double secondSide;
            double thirdSide;
            // It is numerator by found height of triangle.
            double numerator;
            // It is denominator by found height of triangle.
            double denominator;

            numerator = side * Math.Tan(ConvertAngle(firstAngle));
            denominator = Math.Tan(ConvertAngle(firstAngle)) / Math.Tan(ConvertAngle(secondAngle)) + 1;

            secondSide = (numerator / denominator) / Math.Sin(ConvertAngle(firstAngle));
            thirdSide = (numerator / denominator) / Math.Sin(ConvertAngle(secondAngle));

            perimeter = side + secondSide + thirdSide;

            return Math.Round(perimeter, 2);
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

        private void InputFirstSide()
        {
            Console.WriteLine("Input the first side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out _firstSideTriangle)) && (_firstSideTriangle > 0))
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
                if ((double.TryParse(Console.ReadLine(), out _secondSideTriangle)) && (_secondSideTriangle > 0))
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
                if ((double.TryParse(Console.ReadLine(), out _thirdSideTriangle)) && (_thirdSideTriangle > 0))
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

        private bool IsExistsTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide >= secondSide) && (firstSide >= thirdSide) && (firstSide < (secondSide + thirdSide)) ||
               (secondSide >= firstSide) && (secondSide >= thirdSide) && (secondSide < (firstSide + thirdSide)) ||
               (thirdSide >= firstSide) && (thirdSide >= secondSide) && (thirdSide < (firstSide + secondSide)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsExistsTriangle(int firstAngle, int secondAngle)
        {
            if ((firstAngle + secondAngle) < 180)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsExistsTriangle(int firstAngle)
        {
            if (firstAngle < 180)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Calculate(int operation, int formula)
        {
            double resultOperation = 0;

            if (operation == 1)
            {
                switch (formula)
                {
                    case 1:

                        resultOperation = CalculateTriangleSquare(_height, _width);

                        break;

                    case 2:

                        _isExistsTriangle = IsExistsTriangle(_firstSideTriangle, _secondSideTriangle, _thirdSideTriangle);

                        if (_isExistsTriangle)
                        {
                            resultOperation = CalculateTriangleSquare(_firstSideTriangle, _secondSideTriangle, _thirdSideTriangle);
                        }

                        else
                        {
                            Console.WriteLine($"The triangle with sides {_firstSideTriangle}, {_secondSideTriangle}, {_thirdSideTriangle} cannot exist");
                        }

                        break;

                    case 3:

                        _isExistsTriangle = IsExistsTriangle(_firstAngle);

                        if (_isExistsTriangle)
                        {
                            resultOperation = CalculateTriangleSquare(_firstSideTriangle, _secondSideTriangle, _firstAngle);
                        }

                        else
                        {
                            Console.WriteLine($"The triangle with angle {_firstAngle} cannot exist");
                        }

                        break;

                    case 4:

                        _isExistsTriangle = IsExistsTriangle(_firstAngle, _secondAngle);

                        if (_isExistsTriangle)
                        {
                            resultOperation = CalculateTriangleSquare(_firstSideTriangle, _firstAngle, _secondAngle);
                        }

                        else
                        {
                            Console.WriteLine($"The triangle with angles {_firstAngle}, {_secondAngle} cannot exist");
                        }

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

                        _isExistsTriangle = IsExistsTriangle(_firstSideTriangle, _secondSideTriangle, _thirdSideTriangle);

                        if (_isExistsTriangle)
                        {
                            resultOperation = CalculateTrianglePerimeter(_firstSideTriangle, _secondSideTriangle, _thirdSideTriangle);
                        }

                        else
                        {
                            Console.WriteLine($"The triangle with sides {_firstSideTriangle}, {_secondSideTriangle}, {_thirdSideTriangle} cannot exist");
                        }

                        break;

                    case 2:

                        _isExistsTriangle = IsExistsTriangle(_firstAngle);

                        if (_isExistsTriangle)
                        {
                            resultOperation = CalculateTrianglePerimeter(_firstSideTriangle, _secondSideTriangle, _firstAngle);
                        }

                        else
                        {
                            Console.WriteLine($"The triangle with angle {_firstAngle} cannot exist");
                        }

                        break;

                    case 3:

                        _isExistsTriangle = IsExistsTriangle(_firstAngle, _secondAngle);

                        if (_isExistsTriangle)
                        {
                            resultOperation = CalculateTrianglePerimeter(_firstSideTriangle, _firstAngle, _secondAngle);
                        }

                        else
                        {
                            Console.WriteLine($"The triangle with angles {_firstAngle}, {_secondAngle} cannot exist");
                        }

                        break;

                    default:
                        break;
                }
            }

            return resultOperation;
        }

        public double GetParameterFromPerimeter(double perimeter)
        {
            _firstSideTriangle = perimeter / 3;

            _secondSideTriangle = _thirdSideTriangle = _firstSideTriangle;

            return Math.Round(_firstSideTriangle, 2);
        }

        public double GetParameterFromSquare(double square)
        {
            _firstSideTriangle = Math.Pow(square / Math.Pow(0.1875, 0.5), 0.5);

            _secondSideTriangle = _thirdSideTriangle = _firstSideTriangle;
            
            return Math.Round(_firstSideTriangle, 2);
        }

        public void InputData(int operation, int formula)
        {
            if (operation == 1)
            {
                switch (formula)
                {
                    case 1:

                        InputHeight();
                        InputWidth();

                        break;

                    case 2:

                        InputFirstSide();
                        InputSecondSide();
                        InputThirdSide();

                        break;

                    case 3:

                        InputFirstSide();
                        InputSecondSide();
                        InputFirstAngle();

                        break;

                    case 4:

                        InputFirstSide();
                        InputFirstAngle();
                        InputSecondAngle();

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

                        break;

                    case 2:

                        InputFirstSide();
                        InputSecondSide();
                        InputFirstAngle();

                        break;

                    case 3:

                        InputFirstSide();
                        InputFirstAngle();
                        InputSecondAngle();

                        break;

                    default:
                        break;
                }
            }
        }
    }
}
