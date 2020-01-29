using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    // Write your method here:
    public static int Greatest(int vl1, int vl2, int vl3)
    {
      if(vl1>vl2 && vl1>vl3)
      {
        return vl1;
      }
      else if(vl2>vl3)
      {
        return vl2;
      }
      else
      {
        return vl3;
      }
    }
  }
}
