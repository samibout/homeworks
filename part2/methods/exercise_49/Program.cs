using System;

namespace exercise_49
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How many times?");
      int number = Convert.ToInt32(Console.ReadLine());

      // Call your method here:
      for (int i=0;i<number;i++)

      {
        PrintPhrase();
      }  
    }

    // Write your method here:
    public static void PrintPhrase()
    {
      Console.WriteLine("In a hole in the ground there lived a method");  
    }
  }
}
