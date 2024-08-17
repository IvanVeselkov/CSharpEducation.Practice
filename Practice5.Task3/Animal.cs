using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
  public class Animal
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
      Console.WriteLine("Animal is eating");
    }
    public void Sleep()
    {
      Console.WriteLine("Animal is sleeping");
    }

    public virtual void MakeSound()
    {
      Console.WriteLine("Some generic animal sound");
    }
    public Animal(string name,int age)
    {
      Name = name;
      Age = age;
    }
  }
}
