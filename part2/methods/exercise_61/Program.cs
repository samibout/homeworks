<<<<<<< HEAD
﻿using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      //PrintRightTriangle(7);
      ChristmasTree(9);
    }
    public static void ChristmasTree(int height)
    {
      //Maybe I lost my way somewhere, but got to the goal
      int c = height;
      height = height*2;
      for(int a=1;a<height+1;a=a+2)
        
      {
          PrintSpaces(c-a);
          PrintStars(a);
        c++;
      Console.WriteLine();
      }
      int bases = (Convert.ToInt32(height/2)-2);

      for(int i=0;i<2;i++)
      {
        for(int a=0;a<bases;a++)

        {
          Console.Write(" ");
        }
        Console.WriteLine("***");
      }
      Console.WriteLine(bases);
    }
    public static void PrintRightTriangle(int size)
    {
      int c = 1;
      for(int a=1;a<size+1;a=a+2)
        
      {
        c++;

          PrintSpaces(size-a);
          PrintStars(a);
        
      Console.WriteLine();
      } 
    }
    public static void PrintSpaces(int number)
    {
        for(int i=number;i>0;i--){
            Console.Write(" ");}
    }
    public static void PrintStars(int number)
    {
        for(int i=0;i<number;i++){
            Console.Write("*");}
    }
  }
}
=======
﻿using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {

    }

    public static void PrintStars(int number)
    {

    }

    public static void PrintSpaces(int number)
    {

    }

    public static void PrintRightTriangle(int size)
    {

    }

    public static void ChristmasTree(int height)
    {

    }
  }
}
>>>>>>> ee90be72f496cf75bcd6f4184d18fa91124b54a7
