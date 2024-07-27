using System;

namespace Practice2.Task24
{
    class Program
    {
        enum DaysOfWeek
        {
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }
        static void Main(string[] args)
        {
            DayOfWeek d;

            foreach (var days in (DaysOfWeek[])Enum.GetValues(typeof(DaysOfWeek)))
            {
                Console.WriteLine(days);
            }
        }
    }
}
