using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.Write("How many days? ");

      int days = Convert.ToInt32(Console.ReadLine());
      int seconds = days * 24 * 60 * 60;

      Console.WriteLine(seconds);
    }
  }
}
