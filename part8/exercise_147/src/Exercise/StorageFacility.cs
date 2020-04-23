using System.Collections.Generic;
using System;

namespace Exercise
{
  public class StorageFacility
  {
    Dictionary<string, List<string>> storage;

    public StorageFacility()
    {
      List<string> list = new List<string>();
      storage = new Dictionary<string, List<string>>();
    }
    public void Add(string unit, string item)
    {
      if(storage.ContainsKey(unit))
      {
        storage[unit].Add(item);
      }
      else
      {
        List<string> items = new List<string>();
        items.Add(item);
        this.storage.Add(unit, items);        
      }

    }

    public List<string> Contents(string storageUnit)
    {
      if(storage.ContainsKey(storageUnit))
      {
        return new List<string>(storage[storageUnit]);
      }
      return new List<string>();      
  
    }

    public void Remove(string storageUnit, string item)
    {
      if(storage.ContainsKey(storageUnit))
      {
          if(storage[storageUnit].Contains(item))
          {
            storage[storageUnit].Remove(item);
          }
      }
    }

    public List<string> StorageUnits()
    {
      List<string> storunits = new List<string>();
      //return new List<string>();
      foreach(KeyValuePair<string, List<string>> un in storage)
      {
        if(un.Value.Count !=0)
        {
         storunits.Add(un.Key);
        }
      }
      return storunits;
      
    }
  }
}  