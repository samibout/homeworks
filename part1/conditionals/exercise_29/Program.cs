using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      int first = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Give the second number!");
      int second = Convert.ToInt32(Console.ReadLine());

      if(first<second)
      {  
        Console.WriteLine("The larger number is " + second + "!");
      }
      else if(first>second)
      {
        Console.WriteLine("The larger number is " + first + "!");
      } 
      else
      {
        Console.WriteLine("They are equal!");
      }
    }
  }
}
