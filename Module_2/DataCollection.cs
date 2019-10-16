using System;

namespace Module_2
{
    class DataCollection
    {
        private string _txtShape;
        private string _txtOperation;
        private string _txtFormula;

        // Data from method calculate(typeOperation, formula).
        private double _result;

        private int _typeShape;

        private int _typeOperation;

        private int _formula; 
        
        public int TypeShape
        {
            get
            {
                return _typeShape;
            }
        }
        
        public int TypeOperation
        {
            get
            {
                return _typeOperation;
            }
        }
        
        public int Formula
        {
            get
            {
                return _formula;
            }
        }       

        public void ChooseShape()
        {
            Console.WriteLine("Choose shape, please.");            

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Circle input 1. \n" +
                                  "Triangle input 2. \n" +
                                  "Quadrangle input 3.\n");

                if ((int.TryParse(Console.ReadLine(), out _typeShape)) && (_typeShape >= 1) && (_typeShape <= 3))
                {
                  break;
                }

                else
                {
                    Console.WriteLine("Invalid input data, repeat again, please.");
                }
            }
        }

        public void ChooseOperation()
        {
            Console.WriteLine("Choose operation, please.");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Calcilate square input 1. \n" +
                                  "Calculate perimeter input 2. \n");

                if ((int.TryParse(Console.ReadLine(), out _typeOperation)) && (_typeOperation >= 1) && (_typeOperation <= 2))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data, repeat again, please.");
                }
            }
        }
      
        private void ChooseFormulaSquareForTriangle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Height and width are known input 1. \n" +
                                  "All sides are known input 2. \n" +
                                  "Two sides and angle between are known input 3. \n" +
                                  "Two angles and side around them are known input 4. \n");

                if ((int.TryParse(Console.ReadLine(), out _formula)) && (_formula >= 1) && (_formula <= 4))
                {
                    switch (_formula) 
                    {
                        case 1:

                            _txtFormula = "Height and width are known";

                            break;

                        case 2:

                            _txtFormula = "All sides are known";
                        
                            break;

                        case 3:
                        
                            _txtFormula = "Two sides and angle between are known";

                            break;

                        case 4:

                            _txtFormula = "Two angles and side around them are known";

                            break;
                    }

                    break;
                }
                else
                    Console.WriteLine("Invalid input data. repeat again please.");

            }

            _txtOperation = "Square";
        }

        private void ChooseFormulaPerimeterForTriangle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("All sides are known input 1. \n" +
                                  "Two sides and angle between are known input 2. \n" +
                                  "Two angles and side around them are known input 3. \n");

                if ((int.TryParse(Console.ReadLine(), out _formula)) && (_formula >= 1) && (_formula <= 3))
                {
                    switch (_formula)
                    {
                        case 1:

                            _txtFormula = "All sides are known";

                            break;

                        case 2:

                            _txtFormula = "Two sides and angle between are known";

                            break;

                        case 3:

                            _txtFormula = "Two angles and side around them are known";

                            break;
                    }

                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data. repeat again please.");
                }

            }

            _txtOperation = "Perimeter";
        }

        private void ChooseFormulaSquareForCircle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("Radius is known input 1.");

                if ((int.TryParse(Console.ReadLine(), out _formula)) && (_formula == 1))
                {
                    _txtFormula = "Radius is known";

                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data. repeat again please.");
                }

            }

            _txtOperation = "Square";
        }

        private void ChooseFormulaPerimeterForCircle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Radius is known input 1.");

                if ((int.TryParse(Console.ReadLine(), out _formula)) && (_formula == 1))
                {
                    _txtFormula = "Radius is known";

                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input data. repeat again please.");
                }

            }

            _txtOperation = "Perimeter";
        }

        private void ChooseFormulaSquareForQuadrangle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("One side is known input 1. \n" + 
                                  "Height and width are known input 2. \n"+
                                  "All sides are known input 3. \n");

                if ((int.TryParse(Console.ReadLine(), out _formula)) && (_formula >= 1) && (_formula <= 3))
                {
                    switch (_formula)
                    {
                        case 1:

                            _txtFormula = "One side is known";

                            break;

                        case 2:

                            _txtFormula = "Height and width are known";

                            break;

                        case 3:

                            _txtFormula = "All sides are known";

                            break;
                    }

                    break;
                }
                else
                    Console.WriteLine("Invalid input data. repeat again please.");

            }

            _txtOperation = "Square";
        }

        private void ChooseFormulaPerimeterForQuadrangle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("One side is known input 1. \n" +
                                  "Height and width are known input 2. \n" +
                                  "All sides are known input 3. \n");


                if ((int.TryParse(Console.ReadLine(), out _formula)) && (_formula >= 1) && (_formula <= 3))
                {
                    switch (_formula)
                    {
                        case 1:

                            _txtFormula = "One side is known";

                            break;

                        case 2:

                            _txtFormula = "Height and width are known";

                            break;

                        case 3:

                            _txtFormula = "All sides are known";
                            break;
                    }
                    break;
                }

                else
                    Console.WriteLine("Invalid input data. repeat again please.");

            }

            _txtOperation = "Perimeter";

        }

        public void ChooseFormula(int shape, int operation)
        {
            switch (shape)
            {
                case 1:

                    if (operation == 1)
                    {
                        ChooseFormulaSquareForCircle();
                    }

                    else if (operation == 2)
                    {
                        ChooseFormulaPerimeterForCircle();
                    }

                    _txtShape = "Circle";

                    break;

                case 2:

                    if (operation == 1)
                    {
                        ChooseFormulaSquareForTriangle();
                    }

                    else if (operation == 2)
                    {
                        ChooseFormulaPerimeterForTriangle();
                    }

                    _txtShape = "Triangle";
                
                    break;

                case 3:

                    if (operation == 1)
                    {
                        ChooseFormulaSquareForQuadrangle();
                    }

                    else if (operation == 2)
                    {
                        ChooseFormulaPerimeterForQuadrangle();
                    }
                
                    _txtShape = "Quadrangle";  

                    break;

                default:
                    Console.WriteLine("Invalid input data");

                    break;
            }        
        }

        public void Data(ICalculate calculate)
        {
            calculate.InputData(_typeOperation, _formula);
        }

        public void Calculate(ICalculate calculate)
        {
            _result = calculate.Calculate(_typeOperation, _formula);
        }

        public void Show()
        {
            double radius;
            double sideTriangle;
            double sideQuadrangle;

            var additionalShape = "";          

            var circle = new Circle();
            var triangle = new Triangle();
            var quadrangle = new Quadrangle();

            switch (_typeShape)
            {
                case 1:                    

                    if (_typeOperation == 1)
                    {
                        sideTriangle = triangle.GetParameterFromSquare(_result);
                        sideQuadrangle = quadrangle.GetParameterFromSquare(_result);

                        additionalShape = $"Triangle with side {sideTriangle} and quadrangle with side {sideQuadrangle} have the same area";
                    }
                
                    else if(_typeOperation == 2)
                    {
                        sideTriangle = triangle.GetParameterFromPerimeter(_result);
                        sideQuadrangle = quadrangle.GetParameterFromPerimeter(_result);

                        additionalShape = $"Triangle with side {sideTriangle} and quadrangle with side {sideQuadrangle} have the same perimeter";
                    }                                        

                    break;

                case 2:
                
                    if (_typeOperation == 1)
                    {
                        radius = circle.GetParameterFromSquare(_result);
                        sideQuadrangle = quadrangle.GetParameterFromSquare(_result);


                        additionalShape = $"Circle with radius {radius} and quadrangle with side {sideQuadrangle} have the same area";
                    }

                    else if (_typeOperation == 2)
                    {
                        radius = circle.GetParameterFromPerimeter(_result);
                        sideQuadrangle = quadrangle.GetParameterFromPerimeter(_result);

                        additionalShape = $"Circle with radius {radius} and quadrangle with side {sideQuadrangle} have the same perimeter";
                    }

                    break;

                case 3:
                
                    if (_typeOperation == 1)
                    {
                        radius = circle.GetParameterFromSquare(_result);
                        sideTriangle = triangle.GetParameterFromSquare(_result);

                        additionalShape = $"Circle with radius {radius} and triangle with side {sideTriangle} have the same area";
                    }

                    else if (_typeOperation == 2)
                    {
                        radius = circle.GetParameterFromPerimeter(_result);
                        sideTriangle = triangle.GetParameterFromPerimeter(_result);

                        additionalShape = $"Circle with radius {radius} and triangle with side {sideTriangle} have the same perimeter";
                    }

                    break;
            }

            Console.WriteLine($"Shape: {_txtShape}.\n" +
                              $"Operation: {_txtOperation}.\n" +
                              $"Datas: {_txtFormula}. \n" +
                              $"{_txtOperation} is {_result} \n"+
                              additionalShape);

        }
        
    }
}
