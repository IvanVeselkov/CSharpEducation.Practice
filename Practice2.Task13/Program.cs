using System;

namespace Practice2.Task13
{
    class Program
    {
        static int[,] CreateRandomMatrix(int n, int m)
        {
            int[,] a = new int[n,m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = r.Next(0, 100);
                }
            }
            return a;
        }

        static void PrintMatrixInConsole(int[,] a)
        {
            int n = a.GetUpperBound(0) + 1;
            int m = a.GetUpperBound(1) + 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int m = int.Parse(args[1]);
            int number = int.Parse(args[1]);
            PrintMatrixInConsole(CreateRandomMatrix(n, m));
        }
    }
}
