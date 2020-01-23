using System;

namespace exercise_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give input!");
            // Write your code here:
            string message = Console.ReadLine();

            int number =0;

            while(number<3)
            {
                Console.WriteLine(message);
                number++;
            }
        }
    }
}
