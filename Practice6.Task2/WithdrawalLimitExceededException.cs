using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.Task2
{
  public class WithdrawalLimitExceededException:Exception
  {
    public WithdrawalLimitExceededException(string message):base(message)
    {

    }
  }
}
