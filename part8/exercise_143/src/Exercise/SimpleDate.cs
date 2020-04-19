using System.Reflection;

namespace Exercise
{
  public class SimpleDate
  {
    private int day;
    private int month;
    private int year;

    public SimpleDate(int day, int month, int year)
    {
      this.day = day;
      this.month = month;
      this.year = year;
    }

    public override string ToString()
    {
      return this.day + "." + this.month + "." + this.year;
    }

    public bool Earlier(SimpleDate compared)
    {
      if (this.year < compared.year)
      {
        return true;
      }
      if (this.year == compared.year && this.month < compared.month)
      {
        return true;
      }
      if (this.year == compared.year && this.month == compared.month &&
          this.day < compared.day)
      {
        return true;
      }
      return false;
    }

    public override bool Equals(object compared)
    {
      // DO SOMETHING HERE
      if((compared==null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }

      SimpleDate daa = (SimpleDate)compared;
      //if(this.day == daa.day && this.month == daa.month && this.year == daa.year)
      
      if(day.Equals(daa.day) && month.Equals(daa.month) && year.Equals(daa.year))
      {
        return true;
      }
      return false;
    }

    public override int GetHashCode()
    {
      // DO SOMETHING HERE
      int hashsh = (this.day-this.month+this.year)*this.day*this.month*this.year;
      return hashsh;
    }
  }
}