using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Practice5.Task2.Logger;

namespace Practice6.Task2
{
  class SavingsAccount : BankAccount
  {
    ConsoleLogger consoleLogger = new ConsoleLogger();
    public int NextMonthForWithdrawingMoney { get; set; }

    public override void WithdrawAsync(float value)
    {
      if (DateTime.Now.Month!= NextMonthForWithdrawingMoney)
      {
        throw new WithdrawalLimitExceededException("В этом месяце запрещено снимать деньги.");
      }
      else
      {
        NextMonthForWithdrawingMoney++;
        if(NextMonthForWithdrawingMoney>12)
          {
            NextMonthForWithdrawingMoney = 1;
          }
        base.WithdrawAsync(value);
      }
      AccountBalance = base.AccountBalance;
    }


    public SavingsAccount(string accountOwner, string accountNumber, float accountBalance, int monthForWithdrawingMoney):base(accountOwner,accountNumber,accountBalance)
    {
      NextMonthForWithdrawingMoney = monthForWithdrawingMoney;
    }

    public SavingsAccount()
    {
    }
  }
}
