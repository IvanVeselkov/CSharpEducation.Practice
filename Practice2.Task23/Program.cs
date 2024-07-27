using System;

namespace Practice2.Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int n = int.Parse(Console.ReadLine());

            if (n % 400 == 0)
            {
                //високостный
                Console.WriteLine("високосный");
            }
            else
            {
                if((n % 100 != 0))
                {
                    if(n % 4 == 0)
                        Console.WriteLine("високосный");
                    else
                        Console.WriteLine("невисокосный");
                }
                else
                {
                    Console.WriteLine("невисокосный");
                }
            }
        }
    }
}
