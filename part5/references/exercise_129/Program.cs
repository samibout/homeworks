using System;

namespace exercise_129
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Try your code here, if you want
      Song same = new Song("abba", "boo", 235);
      Song sameSame = new Song("abba", "bo", 235);

      if(same.Equals(sameSame))
      {
        Console.WriteLine("Songs are equal.");
      }
      if(same.Equals("Another object"))
      {
        Console.WriteLine("Strange things are afoot.");
      }
    }

  }
}
