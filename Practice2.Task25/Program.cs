using System;

namespace Practice2.Task25
{
    class Program
    {
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели:");
            string n = Console.ReadLine();
            Console.WriteLine(Enum.Parse(typeof(DaysOfWeek), n));
        }
    }
}
