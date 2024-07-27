using System;

namespace Practice2.Task14
{
    class Program
    {
        static int[] CreateEmptyArray(int n)
        {
            int[] a = new int[n];
            return a;
        }

        static void PrintArrayInConsole(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int[] a = CreateEmptyArray(n);
            Console.WriteLine("Введите значения элементов массива:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(i+": \t ");
                a[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine();

            PrintArrayInConsole(a);
        }
    }
}
