﻿using System;
using System.Collections.Generic;

namespace exercise_82
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = { 5, 1, 3, 4, 2 };
      PrintArrayInStars(array);

    }

    public static void PrintArrayInStars(int[] array)
    {
      for(int i=0;i<array.Length;i++)
      {
        for(int a=0;a<array[i];a++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }
      
    }
  }
}

