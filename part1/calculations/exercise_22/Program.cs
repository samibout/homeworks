using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int numbers =0;

      Console.WriteLine("Give the first number!");
      int first = Convert.ToInt32(Console.ReadLine());
      numbers++;
      double firstD = Convert.ToDouble(first);
      
      Console.WriteLine("Give the second number!");
      int second = Convert.ToInt32(Console.ReadLine());
      numbers++;

      Console.WriteLine("Give the third number!");
      int third = Convert.ToInt32(Console.ReadLine());
      numbers++;

      double average = (firstD + second + third) / numbers;          

      Console.WriteLine("The average is " + average);
    }
  }
}
