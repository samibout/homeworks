using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("How old are you?");
      int number = Convert.ToInt32(Console.ReadLine());

      if(number<18)
      {  
        Console.WriteLine("You're under age!");
      }
      else
      {
        Console.WriteLine("You're an adult!");
      }  
    }
  }
}
