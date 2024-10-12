using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task5
{
  public class Matrix
  {
    public int[,] Data {  get; set; }

    public int this[int i1,int i2] { get => Data[i1, i2]; set => Data[i1, i2] = value; }

    public Matrix(int[,] data) { Data = data; }
  }
}
