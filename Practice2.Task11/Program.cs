using System;

namespace Practice2.Task11
{
    class Program
    {
        static int[] CreateArray(int n,int number)
        {
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = number;
            }
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
            int number = int.Parse(args[1]);
            PrintArrayInConsole(CreateArray(n,number));
        }
    }
}
