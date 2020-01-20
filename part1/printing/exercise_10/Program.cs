using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("This is a story telling machine. \nPlease give your name");
            string name = Console.ReadLine();
            Console.WriteLine("And your profession");
            string profs = Console.ReadLine();

            Console.WriteLine("There was a cat named "+name+" and a big cat that was. \nIt has a dream of being a famous "+profs
            +" and later on that it was");
        }
    }
}
