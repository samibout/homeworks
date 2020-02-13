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
        
        string person = Console.ReadLine();
        if(person=="")
        {
          break;
        }
        names.Add(new Item(person));
        
      }
      foreach(Item i in names)
      {
        Console.WriteLine(i); 
      }
    }
  }
}




