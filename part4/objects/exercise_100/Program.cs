using System;

namespace exercise_100
{
  class Program
  {
    public static void Main(string[] args)
    {
      Dept mortgaga = new Dept(120000.0, 1.01);
      mortgaga.PrintBalance();
      mortgaga.WaitOneYear();

      
    }
  }
}



