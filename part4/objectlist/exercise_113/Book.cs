using System;

namespace exercise_113
{
    public class Book
    {
        public string title {get; set;}
        public int year {get; set;}
        public int pages {get; set;}

        public Book(string title, int year, int pages)
        {
            this.title = title;
            this.year = year;
            this.pages = pages;
        }
         
        public override string ToString()
        {
            return this.title + ", " + this.year + " pages, " + this.pages;
        }
            
            
            
    }
}