namespace Exercise
{
  using System.Collections.Generic;
  public class BoxWithMaxWeight : Box
  {
    private int capacity;
    private List<Item> inBox;
    public BoxWithMaxWeight(int capacity)
    {
      this.capacity = capacity;
      this.inBox = new List<Item>();
    }

    public override void Add(Item item)
    {
      int totalWeightInTheBox = 0;
      foreach(Item it in inBox)
      {
        totalWeightInTheBox += it.weight;
      }
      if (totalWeightInTheBox + item.weight <= capacity)
      {
        this.inBox.Add(item);
      }
    }


    public override bool IsInBox(Item item)
    {
      foreach(Item it in inBox)
      {
        if(it.Equals(item))
        {
          return true;
        }
      }
      return false;
    }
  }
}