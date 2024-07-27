using System;

namespace Practice2.Task2
{
    class Program
    {
        static void UserSelectionController()
        {
            int selection = -1;
            Console.WriteLine("Выберите перевод: \t1) метры в километры \n" +
                "\t2) Километры в сантиметры \n" +
                "\t3) м/с в км/ч \n" +
                "\t4) Градусы С в градусы F \n");
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    MetersToKilometers();
                    break;
                case 2:
                    KilometersToСentimetre();
                    break;
                case 3:
                    MetersPerSecondToKilometersPerHour();
                    break;
                case 4:
                    CelsiusToFaringate();
                    break;
                default:
                    UserSelectionController();
                    break;
            }
        }

        static void MetersToKilometers()
        {
            Console.WriteLine("Перевод метров в километры.");
            Console.WriteLine("Введите значение в метрах: ");
            double valueMeters = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Результат: {0} км",valueMeters / 1000.0));
        }

        static void KilometersToСentimetre()
        {
            Console.WriteLine("Перевод километров в сантиметры.");
            Console.WriteLine("Введите значение в километрах: ");
            double valueKilometers = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Результат: {0} см", valueKilometers * 100000.0));
        }

        static void MetersPerSecondToKilometersPerHour()
        {
            Console.WriteLine("Перевод метров в секунду (м/c) в километры в час (к/ч).");
            Console.WriteLine("Введите значение в метрах в секунду (м/c): ");
            double valueMetersPerSecond = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Результат: {0} км/ч", valueMetersPerSecond / 1000.0*3600.0));
        }

        static void CelsiusToFaringate()
        {
            Console.WriteLine("Перевод градусов Цельсия в градусы Фарингейта.");
            Console.WriteLine("Введите значение в градусах Цельсия: ");
            double valueCelsius = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("Результат: {0} f", valueCelsius * 33.8));
        }
        static void Main(string[] args)
        {
            UserSelectionController();
        }
    }
}
