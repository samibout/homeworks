using System.Collections.Generic;
using System;

namespace part1
{
    class Program
    {
        static void Main(string[] args)
        { 
          Numbers number = new Numbers();  
          Console.WriteLine(number.Sum(1234567890));

          Substrings subs = new Substrings();
          Console.WriteLine(subs.Calculate("apassikapsapassitonpassiapassapassipassipaaiipassi","passi"));
           
        }
    }
}
