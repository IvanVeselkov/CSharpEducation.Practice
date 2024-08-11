using System;

namespace Practice4.Task1.MathHelper
{
    public class MathHelper
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            return double.NaN;
        }
    }
}