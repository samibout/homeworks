using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      int num=5;
      int den=3;
      Division(num,den);

    }

    // Write your method here:
    public static void Division(int numerator, int denominator)
    {
      double numerat = numerator;
      double division = numerat/denominator;
      Console.WriteLine(division);
    }
  }
}
