using System;

namespace Practice2.Task19
{
    class Program
    {
        static int[] CreateRandomArray(int n)
        {
            int[] a = new int[n];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 100);
            }
            return a;
        }

        static int FindDifferenceBetweenMaxAndMinInArray(int[] a)
        {
            int max = 0;
            int min = 101;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }    
                if(a[i]<min)
                {
                    min = a[i];
                }
            }
            return max-min;
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
            Random r = new Random();
            int n = r.Next(10, 100);
            int[] a = CreateRandomArray(n);

            Console.WriteLine("Входной массив:");
            PrintArrayInConsole(a);
            Console.WriteLine("Разница между макисмальным и минимальным: "+ FindDifferenceBetweenMaxAndMinInArray(a));
        }
    }
}
