using System;

namespace Practice3.Task10
{
    internal class Program
    {
        private static void GetCarInfo(Car c)
        {
            Console.WriteLine(string.Format("Информация о машине {0}", c.BrandCar));
        }

        private static void Main(string[] args)
        {
            Car c = new Car("FIAT");

            GetCarInfo(c);
        }
    }
}