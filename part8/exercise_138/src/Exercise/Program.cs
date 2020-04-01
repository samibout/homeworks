using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Do something here
      Dictionary<string, string> names = new Dictionary<string, string>();

      names.Add("matthew", "matt");
      names.Add("michael", "mix");
      names.Add("arthur", "artie");

      foreach(string nameAndNick in names.Keys)
      {
        Console.WriteLine(nameAndNick + "'s nickname is " + names[nameAndNick]);
      }
      
    }
  }
}