using System;

namespace Practice3.Task8
{
    internal struct Rectangular
    {
        public double width { get; }
        public double height { get; }

        public Rectangular(double w, double h)
        {
            width = w;
            height = h;
        }
    }

    internal class Program
    {
        private static double SquareRectangular(Rectangular r)
        {
            return r.height * r.width;
        }

        private static void Main(string[] args)
        {
            Rectangular r = new Rectangular(4, 5);
            Console.WriteLine("Площадь прямоугольника со сторонами {0} и {1} : {2}", r.width, r.height, SquareRectangular(r));
        }
    }
}