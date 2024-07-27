using System;

namespace Practice2.Task7
{
    class Program
    {
        static void UserSelectionController()
        {
            int selection = -1;
            Console.WriteLine("Выберите вариант задания:\n " +
                "\t1) перевод в верхний регистр \n" +
                "\t2) перевод в нижний регистр\n" +
                "\t3) заглавная бувка в слове\n");
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Console.Write("Введите слово:");
                    string str1 = Console.ReadLine();
                    Console.WriteLine(string.Format("Результат: {0}",str1.ToUpper()));
                    break;
                case 2:
                    Console.Write("Введите слово:");
                    string str2 = Console.ReadLine();
                    Console.WriteLine(string.Format("Результат: {0}", str2.ToLower()));
                    break;
                case 3:
                    Console.Write("Введите слово:");
                    char[] letters = Console.ReadLine().ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    for(int i=1;i<letters.Length;i++)
                    {
                        letters[i]= char.ToLower(letters[i]);
                    }
                    Console.WriteLine(string.Format("Результат: {0}", new string(letters)));
                    break;
                default:
                    UserSelectionController();
                    break;
            }
        }


        static void Main(string[] args)
        {
            UserSelectionController();
        }
    }
}
