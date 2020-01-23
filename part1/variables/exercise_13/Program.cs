using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Write("Give a number: ");
      string oneInput = Console.ReadLine();

      double number = Convert.ToDouble(oneInput);

      Console.WriteLine("The number you gave is: " + number);
    }
  }
}
