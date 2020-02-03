using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> numbers = new List<int>();

      while(true)
      {
        int number = Convert.ToInt32(Console.ReadLine());

        if(number==9999)
        {
          break;
        }
        numbers.Add(number);
      }
      //search minimum
      int min = numbers[0];
      foreach(int i in numbers)
      {
        if(i<min)
        {
          min=i;
        }
      }

      Console.WriteLine("Smallest number: " + min);

      //search indexes of the minimum values
      for(int i=0;i<numbers.Count;i++)
      {
        if(numbers[i]==min)
        {
          Console.WriteLine("Found at index: " + i);
        }
      }

    }
  }
}
