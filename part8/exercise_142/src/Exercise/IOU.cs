

using System;
using System.Collections.Generic;

namespace Exercise
{
  public class IOU
  {
    Dictionary<string, int> dept;      
     
    public IOU()
    {
      this.dept = new Dictionary<string, int> ();
    }
    
    public void ChangeDebt(string toWhom, int amount)
    {
      if(findIt(toWhom))
      {
      if(dept[toWhom] + amount  >= 0)
          {
            dept[toWhom] += amount;
          }
          else dept[toWhom] = 0;
      }
      else if(amount > 0) 
      {
        dept.Add(toWhom, amount);
      }
        else dept.Add(toWhom, 0);
     
    }

    public int HowMuchDoIOweTo(string toWhom)
    {
      if(findIt(toWhom))
      {
        return dept[toWhom];
      }
      return 0;
    }

    public bool findIt(string toWhom)
    {
      if (dept.ContainsKey(toWhom))
      {
        return true;
      }
      return false;
    }
  }
}
