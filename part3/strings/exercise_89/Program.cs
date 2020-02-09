using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input;
      while(true)
      {
        input = Console.ReadLine();
        if(input=="")
        {
          break;
        }
        string[] pieces = input.Split(" ");
        Console.WriteLine(pieces[pieces.Length-1]);
      }

    }
  }
}



