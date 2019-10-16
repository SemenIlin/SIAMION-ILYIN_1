using System;

namespace Module_2
{
    class Quadrangle : ICalculate
    {
        private double _firstSideQuadrangle;
        private double _secondSideQuadrangle;
        private double _thirdSideQuadrangle;
        private double _fourthSideQuadrangle;

        private bool _isExistsQuadrangle;

        // If Quadrangle is square.
        private double CalculateQuadrangleSquare(double side)
        {
            double square;
            square = Math.Pow(side, 2);

            return Math.Round(square, 2);
        }
        // If Quadrangle is rectangle.
        private double CalculateQuadrangleSquare(double firstSide, double secondSide)
        {
            double square;
            square = firstSide * secondSide;

            return Math.Round(square, 2);
        }

        private double CalculateQuadrangleSquare(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            double square;
            double halfPerimeter;

            halfPerimeter = (firstSide + secondSide + thirdSide + fourthSide) / 2;
            square = Math.Sqrt((halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide) * (halfPerimeter - fourthSide));

            return Math.Round(square, 2);
        }
        // If quadrangle is square.
        private double CalculateQuadranglePerimeter(double side)
        {
            double perimeter;
            perimeter = 4 * side;

            return Math.Round(perimeter, 2);
        }

        // If quadrangle is rectangle
        private double CalculateQuadranglePerimeter(double firstSide, double secondSide)
        {
            double perimeter;
            perimeter = 2 * (firstSide + secondSide);

            return Math.Round(perimeter, 2);
        }

        private double CalculateQuadranglePerimeter(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            double perimeter;
            perimeter = firstSide + secondSide + thirdSide + fourthSide;

            return Math.Round(perimeter, 2);
        }

        private void InputFirstSide()
        {
            Console.WriteLine("Input the first side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out _firstSideQuadrangle)) && (_firstSideQuadrangle > 0))
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
                if ((double.TryParse(Console.ReadLine(), out _secondSideQuadrangle)) && (_secondSideQuadrangle > 0))
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
                if ((double.TryParse(Console.ReadLine(), out _thirdSideQuadrangle)) && (_thirdSideQuadrangle > 0))
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
                if ((double.TryParse(Console.ReadLine(), out _fourthSideQuadrangle)) && (_fourthSideQuadrangle > 0))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        private bool IsExistsQuadrangle(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            if ((firstSide >= secondSide) && (firstSide >= thirdSide) && (firstSide >= fourthSide) && (firstSide < (secondSide + thirdSide + fourthSide)) ||
               (secondSide >= firstSide) && (secondSide >= thirdSide) && (secondSide >= fourthSide) && (secondSide < (firstSide + thirdSide + fourthSide)) ||
               (thirdSide >= firstSide) && (thirdSide >= secondSide) && (thirdSide >= fourthSide) && (thirdSide < (firstSide + secondSide + fourthSide)) ||
               (fourthSide >= firstSide) && (fourthSide >= secondSide) && (fourthSide >= thirdSide) && (fourthSide < (firstSide + secondSide + thirdSide)))
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
                        resultOperation = CalculateQuadrangleSquare(_firstSideQuadrangle);

                        break;

                    case 2:
                        resultOperation = CalculateQuadrangleSquare(_firstSideQuadrangle, _secondSideQuadrangle);

                        break;

                    case 3:
                        _isExistsQuadrangle = IsExistsQuadrangle(_firstSideQuadrangle, _secondSideQuadrangle, _thirdSideQuadrangle, _fourthSideQuadrangle);

                        if (_isExistsQuadrangle)

                        {
                            resultOperation = CalculateQuadrangleSquare(_firstSideQuadrangle, _secondSideQuadrangle, _thirdSideQuadrangle, _fourthSideQuadrangle);
                        }

                        else
                        {
                            Console.WriteLine($"The quadrangle with sides {_firstSideQuadrangle}, {_secondSideQuadrangle}, {_thirdSideQuadrangle}, {_fourthSideQuadrangle} cannot exist");
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
                        resultOperation = CalculateQuadranglePerimeter(_firstSideQuadrangle);

                        break;

                    case 2:
                        resultOperation = CalculateQuadranglePerimeter(_firstSideQuadrangle, _secondSideQuadrangle);

                        break;

                    case 3:

                        _isExistsQuadrangle = IsExistsQuadrangle(_firstSideQuadrangle, _secondSideQuadrangle, _thirdSideQuadrangle, _fourthSideQuadrangle);

                        if (_isExistsQuadrangle)
                        {
                            resultOperation = CalculateQuadranglePerimeter(_firstSideQuadrangle, _secondSideQuadrangle, _thirdSideQuadrangle, _fourthSideQuadrangle);
                        }

                        else
                        {
                            Console.WriteLine($"The quadrangle with sides {_firstSideQuadrangle}, {_secondSideQuadrangle}, {_thirdSideQuadrangle}, {_fourthSideQuadrangle} cannot exist");
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
            _firstSideQuadrangle = perimeter / 4;

            _secondSideQuadrangle = _thirdSideQuadrangle = _fourthSideQuadrangle = _firstSideQuadrangle;

            return Math.Round(_firstSideQuadrangle, 2);
        }

        public double GetParameterFromSquare(double square)
        {
            _firstSideQuadrangle = Math.Pow(square, 0.5);

            _secondSideQuadrangle = _thirdSideQuadrangle = _fourthSideQuadrangle = _firstSideQuadrangle;

            return Math.Round(_firstSideQuadrangle, 2);
        }

        public void InputData(int operation, int formula)
        {
            if (operation == 1)
            {
                switch (formula)
                {
                    case 1:

                        InputFirstSide();

                        break;

                    case 2:

                        InputFirstSide();
                        InputSecondSide();

                        break;

                    case 3:

                        InputFirstSide();
                        InputSecondSide();
                        InputThirdSide();
                        InputFourthSide();                       

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

                        break;

                    case 2:

                        InputFirstSide();
                        InputSecondSide();

                        break;

                    case 3:

                        InputFirstSide();
                        InputSecondSide();
                        InputThirdSide();
                        InputFourthSide();

                        break;

                    default:
                        break;
                }
            }
        }

    }
}
