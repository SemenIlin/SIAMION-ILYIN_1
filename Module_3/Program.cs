using System;

namespace Module_3
{
    class Program
    {
        static void Main()
        {
            string format = "{0,5}";
            int[,] array;

            Console.WriteLine("The program for create vortex array.");
            try
            {
                Console.WriteLine("Input length array.");
                int.TryParse(Console.ReadLine(),out int length);
                var vortexArray = new VortexArray(length);              

                array = vortexArray.GetVortexArray();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(format, array[i, j]);
                    }
                    Console.WriteLine();
                }
                
            }
            catch (OverflowException exception)
            {
                Console.WriteLine(exception.Message);            
            }


            Console.WriteLine("\n");
            Bissection bissection = new Bissection();

            double _middle;
            double _length;
            double _result;
            double _leftValue = 1;
            double _rightValue = 100;
            const double _accurary = 0.000001;

            Console.WriteLine("2,56*x*х - 35*х + 12 = 0.");

            while (true)
            {
                _middle = bissection.GetMiddleLine(_leftValue, _rightValue);
                _length = bissection.GetLengthLine(_leftValue, _rightValue);

                _result = bissection.GetResultFunction(_leftValue, _rightValue);

                _leftValue = _result < 0 ? _leftValue : _middle;
                _rightValue = _result < 0 ? _middle : _rightValue;

                if (_accurary >= _length)
                {
                    break;                
                }
            }

            Console.WriteLine($"Answer {_leftValue}.");

            Console.ReadKey();
        }
    }
}
