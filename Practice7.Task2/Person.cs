using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task2
{
  public class Person:ICloneable
  {
    public string Name { get; set; }
    public int Age { get; set; }

   


    public object Clone()
    {
      return new Person(Name, Age);
    }

    public Person() { }
    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }
  }
}
