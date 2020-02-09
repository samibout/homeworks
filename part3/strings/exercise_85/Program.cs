using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter username:");
      string username = Console.ReadLine();

      Console.WriteLine("Enter password:");
      string password = Console.ReadLine();

      

      CheckLogin(username,password);
      
    }

    public static void CheckLogin(string username, string password)
    {
      string[] usernames = {"alex","emma"};
      string[] passwords = {"sunshine","haskell"};

      for(int i=0;i<usernames.Length;i++)
        {
          if(usernames[i]==username && passwords[i]==password)
          {
            Console.WriteLine("You have successfully logged in!");
            return;
          }
        }
        Console.WriteLine("Incorrect username or password!");

    }
  }
}

