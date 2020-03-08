namespace exercise_136
{
  public class Person
  {
    private string name;
    private int age;

    public Person(string givenName)
    {
      this.name = givenName;
      this.age = 0;
    }

    public bool IsOfAge()
    {
      return (this.age >= 18);
    }

    public int HowManyNames()
    {
      // Do something here
      if(name.Length > 0)
      {
        string[] pieces = System.Text.RegularExpressions.Regex.Split(name.ToString(), @"\s+");
        
        return pieces.Length;
      }
      return 0;
    }

    public void GrowOlder()
    {
      this.age++;
    }

    public override string ToString()
    {
      return this.name;
    }
  }
}