namespace exercise_128
{

  using System;
  public class Apartment
  {

    private int rooms;
    private int squares;
    private int pricePerSquare;

    public Apartment(int rooms, int squares, int pricePerSquare)
    {
      this.rooms = rooms;
      this.squares = squares;
      this.pricePerSquare = pricePerSquare;
    }

    public bool LargerThan(Apartment compared)
    {
      Console.WriteLine(this.squares);
      Console.WriteLine(compared.squares);
      if(this.squares > compared.squares)
      {
        return true;
      }
      return false;
    }

    private int Price()
    {
      return squares * pricePerSquare;
    }

    public int PriceDifference(Apartment compared)
    {
      int priceD = this.Price() - compared.Price();
      // Math.Abs returns the absolute value
      return Math.Abs(priceD);
    }

    public bool MoreExpensiveThan(Apartment compared)
    {
      if(this.Price() > compared.Price())
      {
        return true;
      }
      return false;
    }
  }

}
