using System;

namespace Module_2
{
    class DataCollection
    {
        string shape_txt;
        string operation_txt;
        string formula_txt;

        // Data from method calculate(typeOperation, formula).
        double result;

        int typeShape;

        int typeOperation;

        int formula; 
        
        public int TypeShape { get { return typeShape; } }
        
        public int TypeOperation { get { return typeOperation; } }
        
        public int Formula { get { return formula; } }       

        public void ChooseShape()
        {
            Console.WriteLine("Choose shape, please.");            

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Circle input 1. \n" +
                                  "Triangle input 2. \n" +
                                  "Quadrangle input 3.\n");

                if ((int.TryParse(Console.ReadLine(), out typeShape)) && (typeShape >= 1) && (typeShape <= 3))
                    break;

                else
                    Console.WriteLine("Invalid input data, repeat again, please.");
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

                if ((int.TryParse(Console.ReadLine(), out typeOperation)) && (typeOperation >= 1) && (typeOperation <= 2))
                    break;

                else
                    Console.WriteLine("Invalid input data, repeat again, please.");
            }
        }

        void ChooseFormulaSquareForTriangle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Height and width are known input 1. \n" +
                                  "All sides are known input 2. \n" +
                                  "Two sides and angle between are known input 3. \n" +
                                  "Two angles and side around them are known input 4. \n");

                if ((int.TryParse(Console.ReadLine(), out formula)) && (formula >= 1) && (formula <= 4))
                {
                    switch (formula) 
                    {
                        case 1:

                            formula_txt = "Height and width are known";

                            break;

                        case 2:

                            formula_txt = "All sides are known";

                            break;

                        case 3:

                            formula_txt = "Two sides and angle between are known";

                            break;

                        case 4:

                            formula_txt = "Two angles and side around them are known";

                            break;
                    }

                    break;
                }
                else
                    Console.WriteLine("Invalid input data. repeat again please.");

            }

            operation_txt = "Square";
        }

        void ChooseFormulaPerimeterForTriangle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("All sides are known input 1. \n" +
                                  "Two sides and angle between are known input 2. \n" +
                                  "Two angles and side around them are known input 3. \n");

                if ((int.TryParse(Console.ReadLine(), out formula)) && (formula >= 1) && (formula <= 3))
                {
                    switch (formula)
                    {
                        case 1:

                            formula_txt = "All sides are known";

                            break;

                        case 2:

                            formula_txt = "Two sides and angle between are known";

                            break;

                        case 3:

                            formula_txt = "Two angles and side around them are known";

                            break;
                    }

                    break;
                }

                else
                    Console.WriteLine("Invalid input data. repeat again please.");

            }

            operation_txt = "Perimeter";
        }

        void ChooseFormulaSquareForCircle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("Radius is known input 1.");

                if ((int.TryParse(Console.ReadLine(), out formula)) && (formula == 1))
                {
                    formula_txt = "Radius is known";

                    break;
                }

                else
                    Console.WriteLine("Invalid input data. repeat again please.");

            }

            operation_txt = "Square";
        }

        void ChooseFormulaPerimeterForCircle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Radius is known input 1.");

                if ((int.TryParse(Console.ReadLine(), out formula)) && (formula == 1))
                {
                    formula_txt = "Radius is known";

                    break;
                }

                else
                    Console.WriteLine("Invalid input data. repeat again please.");

            }

            operation_txt = "Perimeter";
        }

        void ChooseFormulaSquareForQuadrangle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("One side is known input 1. \n" + 
                                  "Height and width are known input 2. \n"+
                                  "All sides are known input 3. \n");

                if ((int.TryParse(Console.ReadLine(), out formula)) && (formula >= 1) && (formula <= 3))
                {
                    switch (formula)
                    {
                        case 1:

                            formula_txt = "One side is known";

                            break;

                        case 2:

                            formula_txt = "Height and width are known";

                            break;

                        case 3:

                            formula_txt = "All sides are known";

                            break;
                    }

                    break;
                }
                else
                    Console.WriteLine("Invalid input data. repeat again please.");

            }

            operation_txt = "Square";
        }

        void ChooseFormulaPerimeterForQuadrangle()
        {
            Console.WriteLine("Choose formula");

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("One side is known input 1. \n" +
                                  "Height and width are known input 2. \n" +
                                  "All sides are known input 3. \n");

                if ((int.TryParse(Console.ReadLine(), out formula)) && (formula >= 1) && (formula <= 3))
                {
                    switch (formula)
                    {
                        case 1:

                            formula_txt = "One side is known";

                            break;

                        case 2:

                            formula_txt = "Height and width are known";

                            break;

                        case 3:

                            formula_txt = "All sides are known";

                            break;
                    }
                    break;
                }

                else
                    Console.WriteLine("Invalid input data. repeat again please.");

            }

            operation_txt = "Perimeter";
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

                    shape_txt = "Circle";

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

                    shape_txt = "Triangle";

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

                    shape_txt = "Quadrangle";

                    break;

                default:
                    Console.WriteLine("Invalid input data");

                    break;
            }        
        }

        public void Data(ICalculate calculate)
        {
            calculate.InputData(typeOperation, formula);
        }

        public void Calculate(ICalculate calculate)
        {
            result = calculate.Calculate(typeOperation, formula);
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

            switch (typeShape)
            {
                case 1:                    

                    if (typeOperation == 1)
                    {
                        sideTriangle = triangle.GetParameterFromSquare(result);
                        sideQuadrangle = quadrangle.GetParameterFromSquare(result);

                        additionalShape = $"Triangle with side {sideTriangle} and quadrangle with side {sideQuadrangle} have the same area";
                    }

                    else if(typeOperation == 2)
                    {
                        sideTriangle = triangle.GetParameterFromPerimeter(result);
                        sideQuadrangle = quadrangle.GetParameterFromPerimeter(result);

                        additionalShape = $"Triangle with side {sideTriangle} and quadrangle with side {sideQuadrangle} have the same perimeter";
                    }                                        

                    break;

                case 2:
                    if (typeOperation == 1)
                    {
                        radius = circle.GetParameterFromSquare(result);
                        sideQuadrangle = quadrangle.GetParameterFromSquare(result);

                        additionalShape = $"Circle with radius {radius} and quadrangle with side {sideQuadrangle} have the same area";
                    }

                    else if (typeOperation == 2)
                    {
                        radius = circle.GetParameterFromPerimeter(result);
                        sideQuadrangle = quadrangle.GetParameterFromPerimeter(result);

                        additionalShape = $"Circle with radius {radius} and quadrangle with side {sideQuadrangle} have the same perimeter";
                    }

                    break;

                case 3:

                    if (typeOperation == 1)
                    {
                        radius = circle.GetParameterFromSquare(result);
                        sideTriangle = triangle.GetParameterFromSquare(result);

                        additionalShape = $"Circle with radius {radius} and triangle with side {sideTriangle} have the same area";
                    }

                    else if (typeOperation == 2)
                    {
                        radius = circle.GetParameterFromPerimeter(result);
                        sideTriangle = triangle.GetParameterFromPerimeter(result);

                        additionalShape = $"Circle with radius {radius} and triangle with side {sideTriangle} have the same perimeter";
                    }

                    break;
            }

            Console.WriteLine($"Shape: {shape_txt}.\n" +
                              $"Operation: {operation_txt}.\n" +
                              $"Datas: {formula_txt}. \n" +
                              $"{operation_txt} is {result} \n"+
                              additionalShape);

        }
        
    }
}
