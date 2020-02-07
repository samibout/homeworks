using System;
using System.Collections.Generic;

namespace exercise_83
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a word: ");
      string word = Console.ReadLine();
      
      for(int i=0;i<3;i++)
      {
        Console.Write(word);
      }
      Console.WriteLine();
    }

  }
}

