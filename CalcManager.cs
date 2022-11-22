using System;

namespace Calculator
{
    class CalcManager
    {
        public double add(double x, double y)
        {
            return x + y;
        }

        public double sub(double x, double y)
        {
            return x - y;
        }

        public double mul(double x, double y)
        {
            return x * y;
        }

        public double div(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
                return 0;
        }
    }
}