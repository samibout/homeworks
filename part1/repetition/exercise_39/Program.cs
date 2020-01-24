using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int answer = 1;
      int sum = 0;

      while(answer != 0)
      {
        Console.WriteLine("Give a number:");
        answer = Convert.ToInt32(Console.ReadLine());

        if(answer == 0)
        {
          Console.WriteLine("Total sum of numbers: " + sum);
        }
        else 
        {
          sum = sum + answer;
        } 
      }  
    }
  }
}
