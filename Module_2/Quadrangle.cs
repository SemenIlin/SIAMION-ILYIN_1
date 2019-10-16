using System;

namespace Module_2
{
    class Quadrangle : ICalculate
    {
        public double firstSideQuadrangle;

        public double secondSideQuadrangle;

        public double thirdSideQuadrangle;

        public double fourthSideQuadrangle;

        // If Quadrangle is square.
        double CalculateQuadrangleSquare(double side)
        {
            double square;
            square = Math.Pow(side, 2);

            return Math.Round(square, 2);
        }
        // If Quadrangle is rectangle.
        double CalculateQuadrangleSquare(double firstSide, double secondSide)
        {
            double square;
            square = firstSide * secondSide;

            return Math.Round(square, 2);
        }

        double CalculateQuadrangleSquare(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            double square;
            double halfPerimeter;

            halfPerimeter = (firstSide + secondSide + thirdSide + fourthSide) / 2;
            square = Math.Sqrt((halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide) * (halfPerimeter - fourthSide));

            return Math.Round(square, 2);
        }
        // If quadrangle is square.
        double CalculateQuadranglePerimeter(double side)
        {
            double perimeter;
            perimeter = 4 * side;

            return Math.Round(perimeter, 2);
        }

        // If quadrangle is rectangle
        double CalculateQuadranglePerimeter(double firstSide, double secondSide)
        {
            double perimeter;
            perimeter = 2 * (firstSide + secondSide);

            return Math.Round(perimeter, 2);
        }

        double CalculateQuadranglePerimeter(double firstSide, double secondSide, double thirdSide, double fourthSide)
        {
            double perimeter;
            perimeter = firstSide + secondSide + thirdSide + fourthSide;

            return Math.Round(perimeter, 2);
        }

        void InputFirstSide()
        {
            Console.WriteLine("Input the first side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out firstSideQuadrangle) && firstSideQuadrangle > 0))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        void InputSecondSide()
        {
            Console.WriteLine("Input the second side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out secondSideQuadrangle) && secondSideQuadrangle > 0))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        void InputThirdSide()
        {
            Console.WriteLine("Input the third side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out thirdSideQuadrangle) && thirdSideQuadrangle > 0))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        void InputFourthSide()
        {
            Console.WriteLine("Input the fourth side, please");

            while (true)
            {
                if ((double.TryParse(Console.ReadLine(), out fourthSideQuadrangle) && fourthSideQuadrangle > 0))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data, repeat again please.");
                }
            }
        }

        bool IsExistsQuadrangle(double firstSide, double secondSide, double thirdSide, double fourthSide)
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
                        resultOperation = CalculateQuadrangleSquare(firstSideQuadrangle);

                        break;

                    case 2:
                        resultOperation = CalculateQuadrangleSquare(firstSideQuadrangle, secondSideQuadrangle);

                        break;

                    case 3:

                        if (IsExistsQuadrangle(firstSideQuadrangle, secondSideQuadrangle, thirdSideQuadrangle, fourthSideQuadrangle))

                        {
                            resultOperation = CalculateQuadrangleSquare(firstSideQuadrangle, secondSideQuadrangle, thirdSideQuadrangle, fourthSideQuadrangle);
                        }

                        else
                        {
                            Console.WriteLine($"The quadrangle with sides {firstSideQuadrangle}, {secondSideQuadrangle}, {thirdSideQuadrangle}, {fourthSideQuadrangle} cannot exist");
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
                        resultOperation = CalculateQuadranglePerimeter(firstSideQuadrangle);

                        break;

                    case 2:
                        resultOperation = CalculateQuadranglePerimeter(firstSideQuadrangle, secondSideQuadrangle);

                        break;

                    case 3:

                        if (IsExistsQuadrangle(firstSideQuadrangle, secondSideQuadrangle, thirdSideQuadrangle, fourthSideQuadrangle))
                        {
                            resultOperation = CalculateQuadranglePerimeter(firstSideQuadrangle, secondSideQuadrangle, thirdSideQuadrangle, fourthSideQuadrangle);
                        }

                        else
                        {
                            Console.WriteLine($"The quadrangle with sides {firstSideQuadrangle}, {secondSideQuadrangle}, {thirdSideQuadrangle}, {fourthSideQuadrangle} cannot exist");
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
            firstSideQuadrangle = perimeter / 4;

            secondSideQuadrangle = thirdSideQuadrangle = fourthSideQuadrangle = firstSideQuadrangle;

            return Math.Round(firstSideQuadrangle, 2);
        }

        public double GetParameterFromSquare(double square)
        {
            firstSideQuadrangle = Math.Pow(square, 0.5);

            secondSideQuadrangle = thirdSideQuadrangle = fourthSideQuadrangle = firstSideQuadrangle;

            return Math.Round(firstSideQuadrangle, 2);
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
