﻿using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Write("Give an integer: ");
      string number = Console.ReadLine();

      int intValue = Convert.ToInt32(number);

      Console.WriteLine("You gave number "+intValue);
    }
  }
}
