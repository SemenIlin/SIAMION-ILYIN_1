using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    interface ICalculate
    {
        double Calculate(int operation, int formula);

        double GetParameterFromPerimeter(double perimeter);

        double GetParameterFromSquare(double square);

        void InputData(int operation = 1,int formula = 1);
    }
}
