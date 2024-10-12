using System;
using Practice5.Task2.Logger;
/// <summary>
/// Создайте класс, представляющий банковский счет. Добавьте методы для
/// депозита и снятия денег с этого счета. Добавьте проверки на возможные
/// исключения, такие как недостаточный баланс или отрицательная сумма.
/// Если возникает исключение, студенты должны создать пользовательское
/// исключение и выбросить его с соответствующим сообщением.
///   a. Добавьте несколько типов счетов: обычный счет и накопительный
///     счет. Для накопительного счета установите ограничение, что  
///     нельзя снимать деньги чаще, чем раз в месяц. При нарушении
///     этого ограничения выбрасывается пользовательское исключение
///     WithdrawalLimitExceededException

/// </summary>
namespace Practice6.Task2
{
  
  class Program
  {
    
    static void Main(string[] args)
    {
      BankBase bankBase = BankBase.getInstance();
      ConsoleLogger consoleLogger = new ConsoleLogger();
      bool programmState = true;
      do
      {
        Console.WriteLine("T-Банк.");
        Console.WriteLine("Выберите действие.");
        Console.WriteLine("1. Посмотреть всех пользователей. \n" +
          "2. Добавить накопительный счет.\n" +
          "3. Добавить дебетовый счет.\n" +
          "4. Внести деньги на счет.\n" +
          "5. Снять деньги счета.\n" +
          "6. Закрыть программу.\n");
        string userVariant = Console.ReadLine();
        switch (userVariant)
        {
          case "1":
            Console.WriteLine("Вывод счетов:");
            foreach(var i in bankBase.Accounts)
            {
              Console.WriteLine(string.Format("{0}|{1}|{2}", i.AccountNumber, i.AccountOwner, i.AccountBalance)+"\n");
            }
            break;
          case "2":
            Console.WriteLine("Добавить накопительный счет:");
            Console.WriteLine("Введите данные счета:");
            Console.Write("Имя владельца счета:");
            string ownerSavingName = Console.ReadLine();
            Console.Write("Номер счета:");
            string accountSavingNumber = Console.ReadLine();
            bankBase.Accounts.Add(new SavingsAccount(ownerSavingName, accountSavingNumber, 0f, DateTime.Now.Month));
            break;
          case "3":
            Console.WriteLine("Добавить накопительный счет:");
            Console.WriteLine("Введите данные счета:");
            Console.Write("Имя владельца счета:");
            string ownerName = Console.ReadLine();
            Console.Write("Номер счета:");
            string accountNumber = Console.ReadLine();
            bankBase.Accounts.Add(new BankAccount(ownerName, accountNumber, 0f));
            break;
          case "5":
            Console.WriteLine("Снять деньги с счета:");
            Console.WriteLine("Введите данные счета:");
            Console.Write("Номер счета:");
            string accountNumberForTakeMoney = Console.ReadLine();
            IAccount account = null;
            foreach(var i in bankBase.Accounts)
            {
              if(i.AccountNumber==accountNumberForTakeMoney)
              {
                account = i;
                break;
              }
            }
            Console.WriteLine("Введите сумму:");
            try
            {
              float sum = float.Parse(Console.ReadLine());
              account.WithdrawAsync(sum);
            }
            catch(WithdrawalLimitExceededException e)
            {
              consoleLogger.Error(e.Message);
            }
            catch (InsufficientAmountException e)
            {
              consoleLogger.Error(e.Message);
            }
            catch (InvalidValueException e)
            {
              consoleLogger.Error(e.Message);
            }
            catch(Exception e)
            {
              consoleLogger.Error(e.Message);
            }
            break;
          case "4":
            Console.WriteLine("Внести деньги на счет:");
            Console.WriteLine("Введите данные счета:");
            Console.Write("Номер счета:");
            string accountNumberForSaveMoney = Console.ReadLine();
            int indexAccount = -1;
            
            for(var i=0;i<bankBase.Accounts.Count;i++)
            {
              if (bankBase.Accounts[i].AccountNumber == accountNumberForSaveMoney)
              {
                indexAccount = i;
                break;
              }
            }
            Console.WriteLine("Введите сумму:");
            try
            {
              float sum = float.Parse(Console.ReadLine());
              bankBase.Accounts[indexAccount].Deposite(sum);
            }
            catch (InsufficientAmountException e)
            {
              consoleLogger.Error(e.Message);
            }
            catch (InvalidValueException e)
            {
              consoleLogger.Error(e.Message);
            }
            catch (Exception e)
            {
              consoleLogger.Error(e.Message);
            }
            break;
          default:
            programmState = false;
            bankBase.SaveBase();
            break;
        }
      }while (programmState) ;
      
    }
  }
}
