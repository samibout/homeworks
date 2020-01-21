using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number");
      int first = int.Parse(Console.ReadLine());
      
      Console.WriteLine("Give the second number");
      int second = System.Convert.ToInt32(Console.ReadLine());

      int sum = first + second;
          

      Console.WriteLine("The sum is " + sum);
    }
  }
}
