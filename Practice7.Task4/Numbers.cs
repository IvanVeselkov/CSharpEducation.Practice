using System.Collections;

namespace Practice7.Task4
{
  public class Numbers
  {
    public int[] NumbersArray { get; set; }

    public IEnumerator<int> GetEnumerator()
    {
      for(int i = 0; i < NumbersArray.Length; i++)
      {
        yield return NumbersArray[i];
      }
    }
   
    
   

    public Numbers(int a, int b)
    {
      int n = b - a;
      NumbersArray = new int[n];
      for (int i = 0; i < n; i++)
      {
        NumbersArray[i] = a + i;
      }
    }

   
  }
}
