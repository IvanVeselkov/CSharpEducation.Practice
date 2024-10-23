using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.Task2
{
  public interface IAccount
  {
    public string AccountNumber { get; set; }

    public string AccountOwner { get; set; }

    public float AccountBalance { get; set; }


    public void Deposite(float value);

    public void WithdrawAsync(float value);
  }
}
