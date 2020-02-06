using System;
using System.Collections.Generic;

namespace exercise_75
{
  class Program
  {
    public static void Main(string[] args)
    {

      List<int> numbers = new List<int>();
      numbers.Add(3);
      numbers.Add(2);
      numbers.Add(6);
      numbers.Add(-1);
      numbers.Add(5);
      numbers.Add(1);
      // Example method calls for testing your method.
      // List<int> numbers = new List<int>();
      // numbers.Add(5);
      
      PrintNumbersInRange(numbers, 0, 5);
      
      //PrintNumbersInRange(numbers, 3, 10);
    }

    public static void PrintNumbersInRange(List<int> numbers, int lowerLimit, int upperLimit)
    { 
      Console.WriteLine("The numbers in the range [0, 5]");
      foreach (int i in numbers)
      {
        if(i>= lowerLimit && i<= upperLimit)
        {
          Console.WriteLine(i);
        }
      } 

    }
    
  }
}

