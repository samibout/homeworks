using System;

namespace exercise_100
{
  class Program
  {
    public static void Main(string[] args)
    {
<<<<<<< HEAD
      Dept mortgaga = new Dept(120000.0, 1.01);
      mortgaga.PrintBalance();
      mortgaga.WaitOneYear();

      
=======
      Debt mortgage = new Debt(120000.0, 1.01);
      mortgage.PrintBalance();
      mortgage.WaitOneYear();
      mortgage.PrintBalance();

      for(int i=0;i<20;i++)
      {
        mortgage.WaitOneYear();
      }
      mortgage.PrintBalance();
>>>>>>> 5751d50b123b99a6271279882eb5204538d898d8
    }
  }
}



