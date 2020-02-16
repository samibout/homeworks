using System;
using System.Collections.Generic;

namespace exercise_111
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<PersonalInformation> list = new List<PersonalInformation>();
      List<string> aList = new List<string>();
      while(true)
      {
        Console.WriteLine("First name:");
        string fName = Console.ReadLine();
        if(fName=="")
        {
          break;
        }
        Console.WriteLine("Last name:");
        string lName = Console.ReadLine();
        Console.WriteLine("Identification number:");
        string id = Console.ReadLine();
        list.Add(new PersonalInformation(fName, lName, id));
        string fullName = fName + " " + lName;
        aList.Add(fullName);
        
      }
        Console.WriteLine();
        foreach(string lame in aList)
        {
          Console.WriteLine(lame);
        }
      
    }
  }
}




