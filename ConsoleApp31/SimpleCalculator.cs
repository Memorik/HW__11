using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
     public class SimpleCalculator
    {
        public double Plus(int num1, int num2)
        {
            double result=num1+num2;

            return result;
        }

        public double Minus(int num1, int num2)
        {
            double result = num1 - num2;

            return result;
        }
        public double Multiplication(int num1, int num2)
        {
            double result = num1 * num2;

            return result;
        }
        public double Division(int num1, int num2)
        {
            double result = num1 / num2;

            return result;
        }
    }
}
