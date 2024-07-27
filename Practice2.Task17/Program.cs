using System;

namespace Practice2.Task17
{
    
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int k = a;
            a = b;
            b = k;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 4;
            Console.WriteLine("Входные значения: a:" + a + "\nb:" + b+"\n");
            Swap(ref a, ref b);
            Console.WriteLine("Результат: a:" + a+"\nb:"+b);
        }
    }
}
