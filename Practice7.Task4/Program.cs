namespace Practice7.Task4
{
  internal class Program
  {
    static void GetEvenNumbers(Numbers ints)
    {
      foreach (var number in ints)
      {
        if(number%2 == 0)
        {
          Console.WriteLine(number);
        }
      }
    }
    static void Main(string[] args)
    {
      Numbers numbers = new Numbers(5, 15);
      GetEvenNumbers(numbers);
    }
  }
}
