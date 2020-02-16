using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!
      List<Book> books = new List<Book>();

      while(true)
      {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        if(title=="")
        {
          break;
        }
        Console.Write("Publication year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Pages: ");
        int pages = Convert.ToInt32(Console.ReadLine());

        books.Add(new Book(title, year, pages));
      }
      Console.Write("\nWhat information will be printed? ");
      string info = Console.ReadLine();
      


        foreach(Book i in books)
        {
          if(info=="everything")

          {
            Console.WriteLine(i);
          }
          else if(info=="title")
          {
            Console.WriteLine(i.title);
          }
          
        }
      

    }
  }
}




