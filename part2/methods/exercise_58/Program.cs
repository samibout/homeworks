using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:
    public static int Smallest(int value1, int value2)
    {
      if(value1<value2)
      {
        return value1;
      }
      else
      {
        return value2;
      }
    } 

  }
}
