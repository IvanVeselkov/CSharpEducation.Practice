using System;

namespace Practice2.Task20
{
    class Program
    {
        static int[,] CreateRandomMatrix(int n, int m)
        {
            int[,] a = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = r.Next(1, 100);
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
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[] FindDifferenceBetweenMaxAndMinInMatrix(int[,] a)
        {
            int n = a.GetUpperBound(0) + 1;
            int m = a.GetUpperBound(1) + 1;
            int[] b = new int[n];
            for (int j = 0; j < n; j++)
            {
                int max = 0;
                int min = 101;
                for (int i = 0; i < m; i++)
                {
                    if (a[j,i] > max)
                    {
                        max = a[j, i];
                    }
                    if (a[j, i] < min)
                    {
                        min = a[j, i];
                    }
                }
                b[j] = max - min;
            }
            return b;
        }

        static void PrintArrayInConsole(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(i+":"+a[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(2, 10);
            int m = r.Next(2, 10);
            int[,] a = CreateRandomMatrix(n,m);

            Console.WriteLine("Входной массив:");
            PrintMatrixInConsole(a);
            int[] b = FindDifferenceBetweenMaxAndMinInMatrix(a);
            Console.WriteLine("Разница между макисмальным и минимальным в каждой строке: ");
            PrintArrayInConsole(b);
        }
    }
}
