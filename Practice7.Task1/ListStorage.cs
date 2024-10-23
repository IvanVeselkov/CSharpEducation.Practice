using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task1
{
  public class ListStorage<T> : IStorage<T>
  {
    private List<T> Storage = new List<T>();

    public int Count => Storage.Count;


    public void Add(T item)
    {
      Storage.Add(item);
    }


    public T Get(int index)
    {
      return Storage[index];
    }
  }
}
