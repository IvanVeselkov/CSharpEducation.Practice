using System;

namespace Practice2.Task9
{
    class Program
    {
        static int[] CreateRandomArray(int n)
        {
            int[] a = new int[n];
            Random r = new Random();
            for(int i=0;i<a.Length;i++)
            {
                a[i] = r.Next(0, 100);
            }
            return a;
        }

        static void PrintArrayInConsole(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+"\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            PrintArrayInConsole(CreateRandomArray(n));
        }
    }
}
