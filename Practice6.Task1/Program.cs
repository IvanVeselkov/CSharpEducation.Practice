using System;
using System.IO;
using System.Threading.Tasks;
using Practice5.Task2.Logger;

namespace Practice6.Task1
{
  class Program
  {
    static ConsoleLogger consoleLogger = new ConsoleLogger();
    static FileLogger fileLogger = new FileLogger();
    static int tryCount = 0;
    static bool TryAgainFile(int a,int b)
    {
      try
      {
        consoleLogger.Info("Результат:" + a / b);
        return true;
      }
      catch (DivideByZeroException)
      {
        consoleLogger.Error("Возникло деление на ноль!!!");
        tryCount++;
        consoleLogger.Info("Попытка № " + tryCount);
        return false;
      }
      catch(ArgumentNullException)
      {
        consoleLogger.Error("Имеется null элемент!!!");
        tryCount++;
        consoleLogger.Info("Попытка № " + tryCount);
        return false;
      }
    }
    static bool TryAgainConsole()
    {
      consoleLogger.Info("Введите два числа:");
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      try
      {
        consoleLogger.Info("Результат:" + a / b);
        return true;
      }
      catch (DivideByZeroException)
      {
        consoleLogger.Error("Возникло деление на ноль!!!");
        tryCount++;
        consoleLogger.Info("Попытка № "+tryCount);
        return false;
      }
    }
    static async Task Main(string[] args)
    {

      bool workNormal = false;
      while (!workNormal)
      {
        consoleLogger.Info("Введите путь к файлу:");
        string filePath = Console.ReadLine();
        int[] numbers = new int[2];
        
      
        try
        {
          using (StreamReader reader = new StreamReader(filePath))
          {
            string? line;
            int k = 0;
            while ((line = await reader.ReadLineAsync()) != null)
            {
              numbers[k] = int.Parse(line);
              k++;
            }
          }
          workNormal = TryAgainFile(numbers[0], numbers[1]);
        }
        catch (FileNotFoundException)
        {
          consoleLogger.Error("Не найден файл, повтори попытку.");
          workNormal = false;
        }
        catch (FormatException)
        {
          consoleLogger.Error("Некоректные данные. Проверьте данные в файле.");
          workNormal = false;
        }
        catch (IndexOutOfRangeException)
        {
          consoleLogger.Error("Некоректные данные. Неверное количество строк.");
          workNormal = false;
        }
        
      }
    }
  }
}
