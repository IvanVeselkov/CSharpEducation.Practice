using System;

namespace Practice2.Task12
{
    class Program
    {
        static string[] CreateStringArray(int n)
        {
            string[] a = new string[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Console.ReadLine();
            }
            Console.ReadLine();
            return a;
        }

        static void PrintArrayInConsole(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            PrintArrayInConsole(CreateStringArray(n));
        }
    }
}
