using System.Collections.Generic;
using System.IO;
using Practice5.Task2.Logger;
using System;

namespace Practice6.Task2
{
  public class BankBase
  {
    public List<IAccount> Accounts;

    private static BankBase instance;

    private ConsoleLogger consoleLogger = new ConsoleLogger();
    public static BankBase getInstance()
    {
      if (instance == null)
        instance = new BankBase();
      return instance;
    }

    public void SaveBase()
    {
      try
      {
        using (StreamWriter sw = new StreamWriter("BankBase.txt",false))
        {
          foreach(var i in Accounts)
          {
            if (i.GetType() == new SavingsAccount().GetType())
              sw.WriteLine(string.Format("{0}|{1}|{2}|{3}", (i as SavingsAccount).AccountOwner, (i as SavingsAccount).AccountNumber, (i as SavingsAccount).AccountBalance, (i as SavingsAccount).NextMonthForWithdrawingMoney));
            else
              sw.WriteLine(string.Format("{0}|{1}|{2}|{3}", i.AccountOwner, i.AccountNumber, i.AccountBalance, "0"));
          }
        }
      }
      catch (FileLoadException)
      {
        consoleLogger.Error("Не могу открыть файл.");
      }
      catch (IOException ex)
      {
        consoleLogger.Error("Файл не может быть открыт, так как он используется другим процессом.");
        consoleLogger.Error(ex.Message);
      }
      catch (Exception)
      {
        consoleLogger.Error("Не числовые значения в переменных.");
      }
    }

    private BankBase()
    {
      Accounts = new List<IAccount>();
      try
      {
        using (StreamReader sr = new StreamReader("BankBase.txt"))
        {
          string line = "";
          string[] data = new string[4];
          while ((line = sr.ReadLine()) != null)
          {
            data = line.Split("|");
            if (data[3] != "0")
              Accounts.Add(new SavingsAccount(data[0], data[1], float.Parse(data[2]), int.Parse(data[3])));
            else
              Accounts.Add(new BankAccount(data[0], data[1], float.Parse(data[2])));
          }
        }
      }catch(FileLoadException)
      {
        consoleLogger.Error("Не могу открыть файл.");
      }
      catch(Exception e)
      {
        consoleLogger.Error("Не числовые значения в переменных."+e.Message);
      }
    }
  }
}
