namespace Exercise
{
  public class Book : IPackable
  {
    string author;
    string name;
    int publicationYear;
   
    public Book(string s, string s2, int i)
    {
      this.author = s;
      this.name = s2;
      this.publicationYear = i;
    }

    public int Weight()
    {
      return 1;
    }

    public override string ToString()
    {
      return this.author + ": " + this.name + " (" + this.publicationYear + ")";
    }
  }
}