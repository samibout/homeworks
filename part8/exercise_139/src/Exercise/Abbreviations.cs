using System.Collections.Generic;

namespace Exercise
{
  public class Abbreviations
  {
    private Dictionary<string, string> dicAbbreviation;

    public Abbreviations()
    {
      this.dicAbbreviation = new Dictionary<string, string>();
    }

    public void AddAbbreviation(string abbreviation, string explanation)
    {
        if(HasAbbreviation(abbreviation)==false)
        
        {
          dicAbbreviation.Add(abbreviation, explanation);
        }
    }

    public bool HasAbbreviation(string abbreviation)
    {
      foreach(string abb in dicAbbreviation.Keys)
      {
        if(abb == abbreviation)
        {
          return true;
        }
      }  
  
      return false;
          
        
    }

    public string FindExplanationFor(string abbreviation)
    {
      if(HasAbbreviation(abbreviation)==true)
      {
        return this.dicAbbreviation[abbreviation];
      }
      else
      return "not found";
    }
  }
}