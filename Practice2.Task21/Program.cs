using System;

namespace Practice2.Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(1, 100);
            Console.WriteLine("Введите число:");
            int m = int.Parse(Console.ReadLine());
            if(n==m)
            {
                Console.WriteLine("Вы угадали!");
            }else
            {
                Console.WriteLine("Вы не угадали!");
            }
        }
    }
}
