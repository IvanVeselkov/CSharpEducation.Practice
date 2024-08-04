using System;

namespace Practice3.Task7
{
    internal enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    internal class Program
    {
        private static int GetCountDaysInMonth(Month _month)
        {
            return DateTime.DaysInMonth(2024, (int)_month);
        }

        private static void Main(string[] args)
        {
            Month j = Month.January;
            Console.WriteLine(string.Format("Количество дней в {0} 2024: {1}", j, GetCountDaysInMonth(j)));
        }
    }
}