using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
      int greatest = 0;
      string oldest="";
      while (true)
      {
        
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        string[] parts = input.Split(",");
        
        //string oldest="";
        if(Convert.ToInt32(parts[1]) > greatest)
        {
          greatest = Convert.ToInt32(parts[1]);
          oldest = parts[0];
        }
      }
      Console.WriteLine("Name of the oldest: " + oldest);
    }
  }
}



