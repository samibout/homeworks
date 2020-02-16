using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<TelevisionProgram> list = new List<TelevisionProgram>();
      while(true)
      {
        Console.Write("Name: ");
        string prName = Console.ReadLine();
        if(prName=="")
        {
          break;
        }
        Console.Write("Duration: ");
        int prDuration = Convert.ToInt16(Console.ReadLine());
        list.Add(new TelevisionProgram(prName, prDuration));
      }
      Console.Write("\nProgram's maximum duration? ");
      int maxD = Convert.ToInt16(Console.ReadLine());

      foreach(TelevisionProgram blaa in list)
      {
        if(blaa.duration <= maxD)
        {
          Console.WriteLine(blaa);
        }
      }
    }
  }
}




