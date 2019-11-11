using System;

namespace task_8
{
    class Bissection
    {
        double _middle;
        double _length;
        double _result;
        const double _accurary = 0.000001;

        private double GetMiddleLine(double value1, double value2)
        {
            return (value1 + value2) / 2;
        }

        private double GetLengthLine(double value1, double value2)
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

        private double GetResultFunction(double left, double right)
        {
            double funcLeft = 2.56 * Math.Pow(left, 2) - 35 * left + 12;
            double funcRight = 2.56 * Math.Pow(GetLengthLine(left, right), 2) - 35 * GetLengthLine(left, right) + 12;

            return funcLeft * funcRight;
        }

        public double GetRezultMethodOfBissection(double leftValue, double rightValue)
        {
            _length = GetLengthLine(leftValue, rightValue);
            if (_accurary >= _length)
            {
                return (leftValue + rightValue) / 2;
            }

            _middle = GetMiddleLine(leftValue, rightValue);
            _result = GetResultFunction(leftValue, rightValue);

            leftValue = _result < 0 ? leftValue : _middle;
            rightValue = _result < 0 ? _middle : rightValue;

            return GetRezultMethodOfBissection(leftValue, rightValue);
        }
    }        
}


