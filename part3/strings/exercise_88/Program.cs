using System;
using System.Collections.Generic;

namespace exercise_88
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
        Console.WriteLine(pieces[0]);
      }
    }
  }
}



