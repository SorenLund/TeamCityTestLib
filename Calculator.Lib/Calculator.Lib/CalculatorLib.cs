using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Lib
{
    public class CalculatorLib
    {
        public double Add(double a, double b)
        {
            var arg1 = a;
            var arg2 = b; 

            var res = arg1 + arg2;
            return res;
        }

        public double Subtract(double a, double b)
        {
            var arg1 = a;
            var arg2 = b;

            var res = arg1 - arg2;
            return res;
        }

        public double Mult(double a, double b)
        {
            var arg1 = a;
            var arg2 = b;

            var res = arg1 * arg2;
            return res;
        }

        public double Div(double a, double b)
        {
            var arg1 = a;
            var arg2 = b;

            var res = arg1 / arg2;
            return res;
        }
    }
}
