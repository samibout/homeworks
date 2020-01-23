using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      //int sum = 0;
      // Write your code here:
      int answer = 1;
      int numbers = 0;

      while(answer != 0)
      {
        Console.WriteLine("Give a number:");
        answer = Convert.ToInt32(Console.ReadLine());

        if(answer == 0)
        {
          Console.WriteLine("Total amount of numbers: " + numbers);
        }
        numbers++;
        
      }
    }
  }
}
