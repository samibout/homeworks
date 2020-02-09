using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      int greatest = 0;

      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] parts = input.Split(",");

        if(Convert.ToInt32(parts[1]) > greatest)
        {
          greatest = Convert.ToInt32(parts[1]);
        }
      }
      Console.WriteLine("Age of the oldest: " + greatest);

      


    }
  }
}



