using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task3
{
  public class Car:IComparer<Car>
  {
    public string Make { get; set; }
    public string Model { get; set; }

    public int Compare(Car x, Car y)
    {
      if (x.Make == y.Make) { return 0; }
      else { if (x.Model == y.Model) { return 0; } else { return 1; } }
    }
  }
}
