using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      int first = Convert.ToInt32(Console.ReadLine());
      double firstD = Convert.ToDouble(first);
      
      Console.WriteLine("Give the second number!");
      int second = Convert.ToInt32(Console.ReadLine());

      int sum = first + second;
      int sub = first - second;
      int mul = first * second;
      double div = firstD / second;
      
      Console.WriteLine(first + " + " + second + " = " + sum);
      Console.WriteLine(first + " - " + second + " = " + sub);
      Console.WriteLine(first + " * " + second + " = " + mul);
      Console.WriteLine(first + " / " + second + " = " + div);
    }
  }
}
