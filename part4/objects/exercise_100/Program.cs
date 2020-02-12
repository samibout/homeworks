using System;

namespace exercise_100
{
  class Program
  {
    public static void Main(string[] args)
    {
      Debt mortgage = new Debt(120000.0, 1.01);
      mortgage.PrintBalance();
      mortgage.WaitOneYear();
      mortgage.PrintBalance();

      for(int i=0;i<20;i++)
      {
        mortgage.WaitOneYear();
      }
      mortgage.PrintBalance();
    }
  }
}



