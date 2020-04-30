namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class ChangeHistory
  {
    private List<int> history;

    public ChangeHistory()
    {
      this.history = new List<int>();
    }

    public void Add(int status)
    {
      this.history.Add(status);
    }

    public void Clear()
    {
      this.history.Clear();
    }

    public int MaxValue()
    {
      int mx = this.history[0];
      foreach(int val in this.history)
      {
        if(val>mx)
        {
          mx = val;
        }
      }

        return mx;
    }

    public int MinValue()
    {
      int mn = this.history[0];
      foreach(int val in this.history)
      {
        if(val<mn)
        {
          mn = val;
        }
      }

        return mn;
    }

    public override string ToString()
    {
      return "Current: " + (history[history.Count-1])+ " Min: " + this.MinValue()
      + " Max: " + this.MaxValue();
    }
  }
}
