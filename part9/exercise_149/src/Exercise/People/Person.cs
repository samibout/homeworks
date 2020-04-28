namespace Exercise
{
  public class Person
  {
    public string name;
    public string address;

    public Person(string name, string address)
    {
      this.name = name;
      this.address = address;
    }
    public override string ToString()
    {
      return name + ", " + address;
    }
  }
}