using System;

namespace Module_2
{
    class Program
    {
        static void Main(string[] args)
        {     
            var dataCollection = new DataCollection();

            var circle = new Circle();
            var triangle = new Triangle();
            var quadrangle = new Quadrangle();

            while (true)
            {
                dataCollection.ChooseShape();

                Console.WriteLine();

                dataCollection.ChooseOperation();

                Console.WriteLine();

                dataCollection.ChooseFormula(dataCollection.TypeShape, dataCollection.TypeOperation);

                switch (dataCollection.TypeShape)
                {
                    case 1:

                        dataCollection.Data(circle);
                        dataCollection.Calculate(circle);

                        dataCollection.Show();

                        break;

                    case 2:

                        dataCollection.Data(triangle);
                        dataCollection.Calculate(triangle);

                        dataCollection.Show();

                        break;

                    case 3:
                        dataCollection.Data(quadrangle);
                        dataCollection.Calculate(quadrangle);

                        dataCollection.Show();

                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Continue press Enter, Exit press Esc. ");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
