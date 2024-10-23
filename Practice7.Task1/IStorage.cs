using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task1
{
  public interface IStorage<T>
  {
    public int Count { get; }
    public void Add(T item);
    public T Get(int index);
    
  }
}
