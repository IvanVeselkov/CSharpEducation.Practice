namespace Practice7.Task6
{
  public static class StringExtension
  {
    public static bool isPalindrome(this string str)
    {
      string _reversestr = "";
      for (int i = str.Length - 1; i >= 0; i--)
      {
        _reversestr += str[i].ToString();
      }
      if (_reversestr == str)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static string ToTitleCase(this string str)
    {
      string newSTr = str[0].ToString().ToUpper();
      for (int i = 1; i < str.Length; i++)
      {
        newSTr += str[i].ToString();
      }
      return newSTr;
    }
  }
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
    }
  }
}
