using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3
{
    class Bissection
    { 
        public double GetMiddleLine(double value1, double value2)
        {
            return (value1 + value2) / 2;        
        }

        public double GetLengthLine(double value1, double value2)
        {
            if (value2 >= value1)
            {
                return value2 - value1;
            }
            else 
            {
                return value1 - value2;            
            }
        }

        public double GetResultFunction(double left, double right)
        {
            double funcLeft = 2.56 * Math.Pow(left, 2) - 35 * left + 12;
            double funcRight = 2.56 * Math.Pow(GetLengthLine(left,right), 2) - 35 * GetLengthLine(left, right) + 12;

            return funcLeft * funcRight;
        }
    }
}
