namespace Exercise
{
  public class Student:Person
  {
    private int credit;

    public Student(string name, string address, int credit) : base(name, address)
    {
      this.credit = credit;
    }
    public Student(string name, string address) : base(name, address)
    {
      this.credit = 0;
    }

    public void Study()
    {
      this.credit++;
    }
    public override string ToString()
    {
      return base.ToString() + " " + "credits: " + credit;
    }
  }
}