using System;

namespace Module_2
{
    class Program
    {
        static void Main(string[] args)
        {     
            var formulaSelection = new FormulaSelection();
            var getDataFromUser = new GetDataFromUser();

            var circle = new Circle();
            var triangle = new Triangle();
            var quadrangle = new Quadrangle();
            
            while (true)
            {
                formulaSelection.ChooseShape();

                Console.WriteLine();

                formulaSelection.ChooseOperation();

                Console.WriteLine();

                formulaSelection.ChooseFormula(formulaSelection.TypeShape, formulaSelection.TypeOperation);

                switch (formulaSelection.TypeShape)
                {
                    case 1:
                        getDataFromUser.InputDataRadius(formulaSelection.TypeOperation,ref circle);
                        getDataFromUser.Calculate(circle, formulaSelection.TypeOperation, formulaSelection.Formula);
                        getDataFromUser.Show(formulaSelection.TypeShape, formulaSelection.TypeOperation, formulaSelection.TxtShape, formulaSelection.TxtOperation, formulaSelection.TxtFormula, circle, triangle, quadrangle);

                        break;

                    case 2:
                        getDataFromUser.InputDataTriangle(formulaSelection.TypeOperation, formulaSelection.Formula, ref triangle);
                        getDataFromUser.Calculate(triangle, formulaSelection.TypeOperation, formulaSelection.Formula);
                        getDataFromUser.Show(formulaSelection.TypeShape, formulaSelection.TypeOperation, formulaSelection.TxtShape, formulaSelection.TxtOperation, formulaSelection.TxtFormula, circle, triangle, quadrangle);

                        break;

                    case 3:
                        getDataFromUser.InputDataQuadrangle(formulaSelection.TypeOperation, formulaSelection.Formula,ref quadrangle);
                        getDataFromUser.Calculate(quadrangle, formulaSelection.TypeOperation, formulaSelection.Formula);
                        getDataFromUser.Show(formulaSelection.TypeShape, formulaSelection.TypeOperation,formulaSelection.TxtShape, formulaSelection.TxtOperation, formulaSelection.TxtFormula, circle, triangle, quadrangle);

                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Continue press Enter, Exit press Esc. ");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
				{
					break;
				}

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
