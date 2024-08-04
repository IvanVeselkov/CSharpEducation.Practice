using System;

namespace Practice3.Task6
{
    internal struct Point
    {
        public int X;
        public int Y;

        public Point(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
    }

    internal class Program
    {
        private static double Distance(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        private static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(1, 2);

            Console.WriteLine("Расстояние: " + Distance(a, b));
        }
    }
}