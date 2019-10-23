using System;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var vortexArray = new VortexArray();

            int _lengthArray = 0;
            int[,] _array;

            Console.WriteLine("The program for create vortex array.");
            while (true)
            {
                Console.WriteLine("Input length array.");
                vortexArray.Verify(Console.ReadLine(), ref _lengthArray);
                while (_lengthArray < 0)
                {
                    Console.WriteLine("The value must be greater than 0 ");
                    vortexArray.Verify(Console.ReadLine(), ref _lengthArray);
                }

                _array = vortexArray.CreateVortexArray(_lengthArray);
                vortexArray.Show(_array);
                
                Console.WriteLine("\n");
                Console.WriteLine("Continue press Enter, Exit press Esc.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
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
