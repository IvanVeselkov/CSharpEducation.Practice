using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task3
{
  public class Book : IComparable
  {
    public string Title { get; set; }
    public string Author { get; set; }
    public int CompareTo(object obj)
    {
      if((obj as Book).Title == Title) { return 0; } else { return 1; }
    }
  }
}
