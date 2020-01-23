using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      int number = Convert.ToInt32(Console.ReadLine());

      if ((number % 2)==0)
      {
        Console.WriteLine("It is even.");
      }
      
      else
      {
        Console.WriteLine("It is odd.");
      }
    }
  }
}
