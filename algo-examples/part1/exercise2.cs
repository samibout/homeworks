using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace part1
{
  public class Substrings
  {
    public int Calculate(string a, string b)
    {

      int match = 0;
      int st = a.Length;
      int sub = b.Length;

      for(int i =0;i<st-(sub-1);i++)
      {
          Console.WriteLine(a.Substring(i, sub));
        if(a.Substring(i, sub) == b)
        {
            match++;
            
        }
      }
      Console.WriteLine(match);
      Console.WriteLine(Regex.Matches(a, b).Count);
      return match;
    }
  }
}