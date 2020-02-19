
namespace exercise_120
{
  public class Cube
  {
    public int length;
    public int volume;

    public Cube(int length)
    {
      this.length = length;
      this.volume = 0;
        
    }
    public int Volume()
    {
        volume = length * length * length;
        return volume;
    }
    public override string ToString()
    {
        return "The length of the edge is " + length + " and the volume " + volume;
    }
  }
 
}