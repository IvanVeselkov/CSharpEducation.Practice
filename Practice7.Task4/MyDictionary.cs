using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practice7.Task4
{
  internal class MyDictionary:IEnumerator
  {
    Dictionary<int, string> Items { get; set; }

    private int position = -1;

    public object Current
    {
      get
      {
        if (position == -1 || position >= Items.Count)
          throw new ArgumentException();
        return Items[position];
      }
    }

    public bool MoveNext()
    {
      if (position < Items.Count - 1)
      {
        position++;
        return true;
      }
      else
        return false;
    }

    public void Reset() => position = -1;

    public MyDictionary(Dictionary<int, string> items)
    {
      Items = items;
    }
  }
}
