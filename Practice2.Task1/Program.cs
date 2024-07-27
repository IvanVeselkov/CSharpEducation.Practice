using System;

namespace Practice2.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            Console.WriteLine("Task1:a");
            for (int i=0;i< 10;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //b
            Console.WriteLine("Task1:b");
            int k0 = 0;
            while(k0<10)
            {
                Console.WriteLine(k0);
                k0++;
            }
            Console.WriteLine();

            //c
            Console.WriteLine("Task1:c");
            int j0 = 0;
            do
            {
                Console.WriteLine(j0);
                j0++;
            } while (j0 < 10);
            Console.WriteLine();

            //d
            Console.WriteLine("Task1:d");
            string phrase0 = "";
            for(int i=0;i<2;i++)
            {
                phrase0 += Console.ReadLine()+" ";
            }
            Console.WriteLine(phrase0);
            Console.WriteLine();

            //e
            Console.WriteLine("Task1:e");
            string phrase1 = "";
            int k1 = 0;
            while (k1 < 2)
            {
                phrase1 += Console.ReadLine() + " ";
                k1++;
            }
            Console.WriteLine(phrase1);
            Console.WriteLine();

            //f
            Console.WriteLine("Task1:f");
            int j1 = 0;
            string phrase2 = "";
            do
            {
                phrase2 += Console.ReadLine() + " ";
                j1++;
            } while (j1 < 2);
            Console.WriteLine(phrase2);
            Console.WriteLine();
        }
    }
}
