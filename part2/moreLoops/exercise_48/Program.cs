using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int number=0;
      int amount=0;
      int sum=0;
      int even=0;
      int odd=0;
      double average;

      Console.WriteLine("Give numbers:");
      
      while (number!=-1)
      {
        number = Convert.ToInt32(Console.ReadLine());
        
        if(number!=-1)
        {
          amount++;
          sum = sum + number;
          if(number%2==0)
          {
            even++;
          }
          else
          {
            odd++;
          }
        }
      }

      average = Convert.ToDouble(sum)/amount;
      Console.WriteLine("Thx! Bye!"); 
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + amount);
      Console.WriteLine("Average: " + average);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);

    }
  }
}
