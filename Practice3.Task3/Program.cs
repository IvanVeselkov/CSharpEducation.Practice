using System;

namespace Practice3.Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Calculator c = new Calculator();
            double a = 4;
            double b = 6;
            Console.WriteLine("Сложение:" + c.Add(a, b));
            Console.WriteLine("Деление:" + c.Division(a, b));
            Console.WriteLine("Вычитание:" + c.Subtraction(a, b));
            Console.WriteLine("Умножение:" + c.Multiplication(a, b));
        }
    }
}