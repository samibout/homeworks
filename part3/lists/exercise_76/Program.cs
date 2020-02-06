using System;
using System.Collections.Generic;

namespace exercise_76
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
      numbers.Add(3);
      numbers.Add(6);
      numbers.Add(-2);

      Console.WriteLine(Sum(numbers));

    }
    public static int Sum(List<int> numbers)
    {
      int sum = 0;
      foreach(int i in numbers)
      {
        sum = sum + i;
      }
      return sum;
    }
  }
}


