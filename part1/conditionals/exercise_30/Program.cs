using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:

      int grade=0;
      Console.WriteLine("Give your percent [0 - 100]:");
      int percent = Convert.ToInt32(Console.ReadLine());

      if(percent<0)
      {  
        Console.WriteLine("Impossible");
        
      }
      else if(percent<50)
      {  
        Console.WriteLine("Fail");
      }
      else if(percent>100)
      {  
        Console.WriteLine("Outstanding!");
      }
      else if(percent<60)
      {  
        grade = 1;
      }
      else if(percent<70)
      {  
        grade = 2;
      }
      else if(percent<80)
      {  
        grade = 3;
      }
      else if(percent<90)
      {  
        grade = 4;
      }
      else if(percent<=100)
      {  
        grade = 5;
      }  

      if (grade > 0)
      {
        Console.WriteLine("Grade: " + grade);
      }    
    }  
  }
}
