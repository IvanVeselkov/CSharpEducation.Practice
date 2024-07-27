using System;

namespace Practice2.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format(" a={0} \n b={1} \n c={2} \n",a,b,c));

            if (a==b || a==c || b==c)
            {
                a += 5;
                b += 5;
                c += 5;
                Console.WriteLine(string.Format(" a={0} \n b={1} \n c={2} \n", a, b, c));
            }
            else
            {
                Console.WriteLine("Равных нет");
            }
        }
    }
}
