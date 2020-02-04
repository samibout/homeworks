using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("Search for?");
      string search = Console.ReadLine();

      for(int i=0;i<list.Count;i++)
      {
        if(list[i] == search)
        {
          Console.WriteLine(search + " was found!"); 
          break;                
        }
        else if(i==list.Count-1)
      {
        Console.WriteLine(search + " was not found!");
      }
      }
      
      
    }
  }
}

