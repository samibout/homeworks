using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int answer = 1;

      while(answer != 0)
      {
        Console.WriteLine("Give a number:");
        answer = Convert.ToInt32(Console.ReadLine());

        if(answer < 0)
        {
          Console.WriteLine("That is negative");
        }
        else if(answer>0)
        {
          Console.WriteLine(answer*answer);
        }
      }  
    }
  }
}
