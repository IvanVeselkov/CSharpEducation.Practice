using System;
using Practice4.Task1.MathHelper;

namespace Practice4.Task2.MathHelperUser
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //addition, subtraction, multiplication, division
            MathHelper mathHelper = new MathHelper();
            double a, b;
            a = 10;
            b = 15;

            Console.WriteLine(string.Format("Addition: {0} + {1} = {2}", a, b, mathHelper.Addition(a, b)));

            Console.WriteLine(string.Format("Subtraction: {0} - {1} = {2}", a, b, mathHelper.Subtraction(a, b)));

            Console.WriteLine(string.Format("Division: {0} / {1} = {2}", a, b, mathHelper.Division(a, b)));

            Console.WriteLine(string.Format("Multiplication: {0} * {1} = {2}", a, b, mathHelper.Multiplication(a, b)));
        }
    }
}