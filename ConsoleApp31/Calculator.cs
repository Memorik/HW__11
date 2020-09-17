using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            SimpleCalculator simp = new SimpleCalculator();
            Console.WriteLine("Write num1");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Write num2");
            int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Write operator");
            char.TryParse(Console.ReadLine(), out char oper);
            double result=0;
            if (oper == '+')
            {
                result= simp.Plus(num1, num2);
            }
            if (oper == '-')
            {
                result = simp.Minus(num1, num2);
            }
            if (oper == '*')
            {
                result = simp.Multiplication(num1, num2);

            }
            if (oper == '/')
            {
                result = simp.Division(num1, num2);

            }

           Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
