using System;

namespace Practice5.Task3
{
  class Program
  {
    static void Main(string[] args)
    {
      Dog d = new Dog("",1,"s");
      d.MakeSound();
      Cat c = new Cat("", 1, "s");
      c.MakeSound();
      Animal parrot = new Parrot("",1,"");
      parrot.MakeSound();

      IFlyable[] flyables = new IFlyable[2] { new Eagle(), new Parrot("", 1, "") };
      flyables[0].Fly();
      flyables[1].Fly();
    }
  }
}
