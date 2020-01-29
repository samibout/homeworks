using System;

namespace exercise_60
{
  class Program
  {
    public static void PrintStars(int number)
    {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
      for(int i=0;i<number;i++)
      {
        Console.Write("*");
      }
      Console.WriteLine();
    }

    public static void PrintSquare(int size)
    {
      for(int a=0;a<size;a++)

      {
        for(int i=0;i<size;i++)
        {
          Console.Write("*");
        }
      Console.WriteLine();
      }
    }

    public static void PrintRectangle(int width, int height)
    {
      for(int a=0;a<height;a++)

      {
        for(int i=0;i<width;i++)
        {
          Console.Write("*");
        }
      Console.WriteLine();
      }  
    }

    public static void PrintTriangle(int size)
    {
      int c = 0;
      for(int a=0;a<size;a++)
        
      {
        c++;
        for(int i=0;i<c;i++)
        {
          Console.Write("*");
        }
        
      Console.WriteLine();
      } 
    }
    public static void Main(String[] args)
    {
      PrintStars(5);
      PrintStars(3);
      PrintStars(9);
      PrintSquare(4);
      PrintRectangle(17,3);
      PrintTriangle(4);
    }

  }
}
