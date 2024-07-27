using System;
using System.Text.RegularExpressions;

namespace Practice2.Task6
{
    class Program
    {
        static double ThePercentageOfOccurrenceOfACharacterInAString(string str,string symbol)
        {
            int amount = new Regex(symbol).Matches(str).Count;
            return amount * 100/str.Length ;

        }

        static void UserSelectionController(string[] arg)
        {
            int selection = -1;
            Console.WriteLine("Выберите вариант задания:\n " +
                "\t1) Процент вхождения сивмола 'o' в строке 'Hello World'. \n" +
                "\t2) Процент вхождения сивмола введенного пользователем в строке введенной пользователем. \n" +
                "\t3) Процент вхождения сивмола из аргумента консоли в строке аргумента консоли. \n");
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Console.WriteLine(string.Format("Процент вхождения: {0}",ThePercentageOfOccurrenceOfACharacterInAString("Hello world", "o")));
                    break;
                case 2:
                    Console.Write("Введите строку:");
                    string line = Console.ReadLine();
                    Console.Write("Введите символ:");
                    string symbol = Console.ReadLine();
                    Console.WriteLine(string.Format("Процент вхождения: {0}", ThePercentageOfOccurrenceOfACharacterInAString(line, symbol)));
                    break;
                case 3:
                    Console.Write(string.Format("Строка из аргументов: {0}",arg[0]));
                    Console.Write("Символ из аргументов: {0}", arg[1]);
                    Console.WriteLine(string.Format("Процент вхождения: {0}", ThePercentageOfOccurrenceOfACharacterInAString(arg[0], arg[1])));
                    break;
                default:
                    UserSelectionController(arg);
                    break;
            }
        }
        static void Main(string[] args)
        {
            UserSelectionController(args);
        }
    }
}
