using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account poor = new Account("Poorman's account", 100.00);
      
      poor.Deposit(20.0);

      Console.WriteLine(poor.balance);
    }
  }
}



