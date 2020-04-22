using System;
using System.Collections.Generic;

namespace Exercise
{
  public class VehicleRegistry
  {
    private Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();
    public bool Add(LicensePlate licensePlate, string owner)
    {
      if(!owners.ContainsKey(licensePlate))
      {
        this.owners.Add(licensePlate, owner);
        return true;
      }
      
      return false;
    }

    public string Get(LicensePlate licensePlate)
    {
      if(owners.ContainsKey(licensePlate))
      {
        return owners[licensePlate];
      }
      return "No such license";
    }

    public bool Remove(LicensePlate licensePlate)
    {
      if(owners.ContainsKey(licensePlate))
      {
        this.owners.Remove(licensePlate);
        return true;
      }
      return false;
    }

    public void PrintLicensePlates()
    {
      foreach(KeyValuePair<LicensePlate, string> kvp in owners)
      {
        Console.WriteLine(kvp.Key);
      }
    }

    public void PrintOwners()
    {
      List<string> owow = new List<string>();

      foreach(KeyValuePair<LicensePlate, string> kvp in owners)
      {
        if(!owow.Contains(kvp.Value))
        {
          owow.Add(kvp.Value);
        }
      }
      owow.ForEach(Console.WriteLine);  
    }
  }
}