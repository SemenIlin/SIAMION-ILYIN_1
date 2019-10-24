using System;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Bissection bissection = new Bissection();

            Console.WriteLine("2,56*x*х - 35*х + 12 = 0.");

            double result = bissection.GetRezultMethodOfBissection(1, 100);

            Console.WriteLine(result);
        }
    }
}
