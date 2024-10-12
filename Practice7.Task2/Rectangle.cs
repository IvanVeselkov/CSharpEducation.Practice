using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task2
{
  public class Rectangle : ICloneable
  {
    public float Width { get; set; }
    public float Height { get; set; }

    public Rectangle() { }
    public Rectangle(float w,float h)
    {
      Width = w;
      Height = h;
    }


    public object Clone()
    {
      return new Rectangle(Width, Height);
    }
  }
}
