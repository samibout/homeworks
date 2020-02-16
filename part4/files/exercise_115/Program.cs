using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input;
      while(true)
      {
        input = Console.ReadLine();
        if(input=="end")
        {
          break;
        }
      
        int toCube = Convert.ToInt32(input);
        Console.WriteLine(toCube*toCube* toCube);
      }
    }
  }
}
