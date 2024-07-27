using System;

namespace Practice2.Task18
{
    class Program
    {
        static void PrintArrayInConsole(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }

        static int[] RemoveNegativeNumbersFromArray(int[] a,out int countNegative)
        {
            countNegative = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<0)
                {
                    countNegative++;
                }
            }

            int[] b = new int[a.Length-countNegative];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    b[k] = a[i];
                    k++;
                }
            }
            return b;
        }
        static void Main(string[] args)
        {
            int n = 0;
            int[] a = new int[] {1,3,-5,3,6 };
            Console.WriteLine("Входной массив:");
            PrintArrayInConsole(a);
            int[] b = RemoveNegativeNumbersFromArray(a, out n);

            Console.WriteLine("Выходной массив:");
            PrintArrayInConsole(b);
            Console.WriteLine("Количество отрицательных чисел: " + n);
        }
    }
}
