using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<Item> names = new List<Item>();
  
      
      while(true)
      {
        Console.Write("Name: ");
        string person = Console.ReadLine();
        if(person=="")
        {
          break;
        }
        names.Add(new Item(person));
        
      }
      Console.WriteLine();
      foreach(Item i in names)
      {
        Console.WriteLine(i); 
      }
    }
  }
}




