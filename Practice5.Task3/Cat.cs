using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
  public class Cat : Animal
  {
   

    public string Breed { get; set; }
    public override void MakeSound()
    {
      Console.WriteLine("Meow");
    }
    public Cat(string name,int age,string breed):base(name,age)
    {
      Breed = breed;
    }
  }
}
