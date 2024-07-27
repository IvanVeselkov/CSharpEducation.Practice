using System;

namespace Practice2.Task16
{
    class Program
    {
        static void ChangeSignature(ref int n)
        {
            n=-n;
        }
        static void Main(string[] args)
        {
            Console.Write("Введи число:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ChangeSignature(ref n);
            Console.WriteLine("Результат: "+n);
        }
    }
}
