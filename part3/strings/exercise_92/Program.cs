using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input;
      string[] split;
      string longest="";
      int length=0;
      int age=0;
      int year=2020;

      while(true)
      {
      
       input=Console.ReadLine();
       if(input=="")
       {
         break;
       }
       split=input.Split(",");

       if(Convert.ToInt32(split[1])<year)
       {
         year=Convert.ToInt32(split[1]);
       }
       if(split[0].Length>length)
       {
         longest = split[0];
         length = split[0].Length;
       }

      }
      age = 2020 - year;
      Console.WriteLine("Longest name: " + longest);
      Console.WriteLine("Highest age: " + age);
    }
  }
}



