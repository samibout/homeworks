using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.Write("Give a string: ");
      string oneString = Console.ReadLine();

      Console.Write("Give an integer: ");
      int oneInt = Convert.ToInt32(Console.ReadLine());
      
      Console.Write("Give a double: ");
      double oneDouble = Convert.ToDouble(Console.ReadLine());

      Console.Write("Give a boolean: ");
      bool oneBool = Convert.ToBoolean(Console.ReadLine());

      Console.WriteLine("Your string is: " + oneString);
      Console.WriteLine("Your integer is: " + oneInt);
      Console.WriteLine("Your double is: " + oneDouble);
      Console.WriteLine("Your boolean is: " + oneBool);
    }
  }
}
