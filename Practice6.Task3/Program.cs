using System;
using Practice5.Task2.Logger;

namespace Practice6.Task3
{
  /// <summary>
  /// Создайте программу, которая принимает от пользователя его возраст и
  /// проверяет его на корректность.Если возраст меньше 18 лет, программа
  /// должна выбросить исключение с сообщением о том, что пользователь
  /// несовершеннолетний.Если возраст равен или больше 18 лет, программа
  /// должна вывести
  ///     a. Реализуйте систему корректировок: если возраст введён
  ///     некорректно, программа должна предлагать пользователю ввести
  ///     другой возраст, а в случае многократных ошибок выбрасывать
  ///     исключение TooManyAttemptsException
  /// </summary>
  class Program
  {
    static void CheckAge(int age,bool enter)
    {
      if(age<18)
      {
        throw new UserAgeException("Недостаточный возраст.");
      }
      else
      {
        Console.WriteLine("Добро пожаловать.");
        enter = true;
      }
    }

    static void Main(string[] args)
    {
      ConsoleLogger consoleLogger = new ConsoleLogger();
      bool enter = false;
      int tryCount = -1;
      do
      {
        try
        {
          
          Console.Write("Введите возраст: ");
          if (tryCount > 1)
          {
            throw new TooManyAttemptsException("Слишком много попыток.");
          }
          tryCount++;
          CheckAge(int.Parse(Console.ReadLine()),enter);
          
        }
        catch (TooManyAttemptsException e)
        {
          consoleLogger.Error(e.Message);
          enter = true;
        }
        catch (UserAgeException e)
        {
          consoleLogger.Error(e.Message);
        }
        catch (Exception e)
        {
          consoleLogger.Error(e.Message);
        }
      } while (!enter);
    }
  }
}
