using System;

namespace Practice2.Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(1, 100);
            int tryCount = 10;
            do
            {
                Console.WriteLine(string.Format("Введите число у вас {0} попыток:", tryCount));
                int m = int.Parse(Console.ReadLine());
                if (n == m)
                {
                    Console.WriteLine("Вы угадали!");
                    break;
                }
                else
                {
                    if(n<m)
                    {
                        Console.WriteLine("Ваше число больше");
                    }
                    else
                    {
                        Console.WriteLine("Ваше число меньше");
                    }

                    
                }
                if(tryCount==1)
                {
                    Console.WriteLine("Вы не угадали!");
                    break;
                }
                tryCount--;
            }
            while (true);
        }
    }
}
