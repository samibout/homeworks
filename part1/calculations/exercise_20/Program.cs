﻿using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      int first = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Give the second number!");
      int second = Convert.ToInt32(Console.ReadLine());

      int multi = first * second;          

      Console.WriteLine(first + " * " + second + " = " + multi);
    }
  }
}
