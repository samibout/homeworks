using System;
using System.IO;

namespace exercise_117
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Ask the user for the file name and print the content of the file
      Console.WriteLine("Which file should have its contents printed?");
      string content = Console.ReadLine() ;

      string text = File.ReadAllText(content);
      Console.WriteLine(text);
      
    }
  }
}
