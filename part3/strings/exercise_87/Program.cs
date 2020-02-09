using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input = "";
      while(true)
      {
        input = Console.ReadLine(); 
        if(input=="")
        {
          break;
        }
         
      string[] pieces = input.Split(" ");

      StringContains(pieces);
      }
    }

    public static void StringContains(string[] words)
    {
      foreach(string word in words)
      {
        if(word.Contains("av"))
        {
          Console.WriteLine(word);
        }
      }
    }
  }

}

