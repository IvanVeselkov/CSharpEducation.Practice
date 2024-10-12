using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.Task2
{
  class BankAccount : IAccount
  {
    public string AccountNumber { get; set; }
    public string AccountOwner { get; set; }
    public float AccountBalance { get; set; }

    public void Deposite(float value)
    {
      if(value<0)
        throw new InvalidValueException("Введено некоректное значение.");
      AccountBalance += value;
    }

    public virtual void WithdrawAsync(float value)
    {
      if (value < 0)
        throw new InvalidValueException("Введено некоректное значение.");
      if (AccountBalance < value)
        throw new InsufficientAmountException("Невозможно снять с баланса текущую сумму");
      AccountBalance -= value;
    }

    public BankAccount(string accountNumber,string accountOwner,float accountBalance)
    {
      AccountNumber = accountNumber;
      AccountOwner = accountOwner;
      AccountBalance = accountBalance;
    }

    public BankAccount()
    {

    }
  }
}
