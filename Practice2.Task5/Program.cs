using System;

namespace Practice2.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сравнение двух целых чисел.");
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            if(a==b)
            {
                Console.WriteLine("Результат: a = b");
            }else
            if(a>b)
            {
                Console.WriteLine("Результат: a > b");
            }else
            if(a<b)
            {
                Console.WriteLine("Результат: a < b");
            }
        }
    }
}
