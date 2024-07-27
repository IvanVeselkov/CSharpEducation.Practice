using System;

namespace Practice2.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выражение: (a+b-f/a)+f*a*a-(a+b). \n" +
                "\t Введите значения переменных. \n");

            int a = 0;
            do
            {
                Console.WriteLine("Значение переменной a:");
                a = int.Parse(Console.ReadLine());
                if(a==0)
                {
                    Console.WriteLine("a не модет быть равна 0");
                }
            } while (a == 0);

            Console.WriteLine("Значение переменной b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Значение переменной f:");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат выражения: {0}", (a + b - f / a)+f*a*a-(a+b));
        }
    }
}
