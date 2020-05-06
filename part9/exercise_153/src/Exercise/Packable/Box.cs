namespace Exercise
{
  public class Box : IPackable
  {
    int maxCapacity;
    int boxWeight;
    int itemCount;
    public Box(int i)
    {
      this.maxCapacity = i;
      this.itemCount = 0;

    }

    public void Add(IPackable item)
    {
      //itemCount = 0;
      if((item.Weight() + this.boxWeight)<=this.maxCapacity)
      {
        this.boxWeight += item.Weight();
        itemCount++;
      }
    }

    public int Weight()
    {
      return this.boxWeight;
    }

    public override string ToString()
    {
      return itemCount + " items, total weight "+this.boxWeight+" kg";
    }
  }
}