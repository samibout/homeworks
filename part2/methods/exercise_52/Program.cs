using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      int yourNumber = Convert.ToInt32(Console.ReadLine());
      PrintFromNumberToOne(yourNumber);
    }

    // Write your method here:
    public static void PrintFromNumberToOne(int number)
    {
      for(int i=number;i>0;i--)
      {
        Console.WriteLine(i);
      }
    }
  }
}
