using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int numberTo;
      int numberFrom;

      Console.WriteLine("Where to?");
      numberTo = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Where from?");
      numberFrom = Convert.ToInt32(Console.ReadLine());

      if(numberTo>numberFrom)
      {
        for(int i=numberFrom;i<=numberTo;i++)
        {
        Console.WriteLine(i);
        }
      }
    }
  }
}
