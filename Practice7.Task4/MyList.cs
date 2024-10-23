using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task4
{
  internal class MyList:IEnumerable
  {
    public List<int> Items { get; set; }



    IEnumerator IEnumerable.GetEnumerator()=>Items.GetEnumerator();

  }
}
