using System.Collections.Generic;
using System;
namespace Exercise
{
  public class DictionaryOfManyTranslations
  {
    Dictionary<string, List<string>> words;
    public DictionaryOfManyTranslations()
    {
      List<string> list = new List<string>();
      words = new Dictionary<string, List<string>>();
    }

    public void Add(string word, string translation)
    {
      if(words.ContainsKey(word))
      {
        List<string> tra = new List<string>(words[word]);
               
          if(!tra.Contains(translation))
          {
            words[word].Add(translation);
          }      
      }
      else
      {
        List<string> transL = new List<string>();
        transL.Add(translation);
        this.words.Add(word, transL);
      }
    }

    public List<string> Translate(string word)
    {
      if(words.ContainsKey(word))
      {
        return new List<string>(words[word]);
      }
      return new List<string>();
    }

    public void Remove(string word)
    {
      if(words.ContainsKey(word))
      {
        words.Remove(word);
      }
    }
  }
}