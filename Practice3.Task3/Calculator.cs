using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task3
{
    internal class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Деление на ноль");
                return -1;
            }
            else
            {
                return a / b;
            }
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }
    }
}