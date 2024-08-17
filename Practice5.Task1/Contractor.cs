using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
  class Contractor:Employee
  {
    

    public int HourlyRate { get; set; }

    public Contractor(string name,double hourlyRate, int hours):base(name, hourlyRate*hours)
    {
      HourlyRate = hours;
    }
  }
}
