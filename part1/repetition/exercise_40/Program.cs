using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int answer = 1;
      int sum = 0;
      int count = 0;
      while(answer != 0)
      {
        Console.WriteLine("Give a number:");
        answer = Convert.ToInt32(Console.ReadLine());

        if(answer == 0)
        {
          Console.WriteLine("Total sum of numbers: " + sum);
          Console.WriteLine("Total amount of numbers: " + count);
        }
        else 
        {
          sum = sum + answer;
          count++;
        } 
      } 
    }
  }
}
