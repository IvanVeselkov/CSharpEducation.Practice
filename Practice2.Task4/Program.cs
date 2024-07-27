using System;

namespace Practice2.Task4
{
    class Program
    {
        static void UserSelectionController()
        {
            int selection = -1;
            Console.WriteLine("Выберите вариант отрисовки треугольника:\n " +
                "\t1) левый треугольник \n" +
                "\t2) правый треугольник \n");
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    PaintLeftTriangleInConsole();
                    break;
                case 2:
                    PaintRightTriangleInConsole();
                    break;
                default:
                    UserSelectionController();
                    break;
            }
        }

        private static void PaintRightTriangleInConsole()
        {
            Console.WriteLine("Рисование правого треугольника.");
            Console.Write("Введите размер треугольника: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Введите символ для рисования треугольника: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("Результат:");
            for(int i=0;i<size;i++)
            {
                string line="";
                for (int k = 0; k < size - i - 1; k++)
                {
                    line += " ";
                }
                Console.Write(line);
                for (int j= size - i - 1; j<size;j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        private static void PaintLeftTriangleInConsole()
        {
            Console.WriteLine("Рисование левого треугольника.");
            Console.Write("Введите размер треугольника: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Введите символ для рисования треугольника: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("Результат:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            UserSelectionController();
        }
    }
}
