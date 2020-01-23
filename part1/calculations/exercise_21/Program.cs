using System;

namespace exercise_21
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

      double average = (firstD + second) / numbers;          

      Console.WriteLine("The average is " + average);
    }
  }
}
