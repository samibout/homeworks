﻿using System;
using System.Collections.Generic;

namespace exercise_70
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      int big=list[0];
      foreach(int i in list)
      {
        if(i>big)
        {
          big=i;
        }
      }
      Console.WriteLine("The greatest number: " + big);
    }
  }
}
