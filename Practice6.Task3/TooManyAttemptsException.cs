using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6.Task3
{
  class TooManyAttemptsException:Exception
  {
    public TooManyAttemptsException(string message):base(message)
    {

    }
  }
}
