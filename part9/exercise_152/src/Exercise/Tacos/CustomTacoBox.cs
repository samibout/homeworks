namespace Exercise
{
  public class CustomTacoBox : ITacoBox
  {
    private int tacoAmount;
    public CustomTacoBox(int tacos)
    {
      this.tacoAmount = tacos;
    }

    public int TacosRemaining()
    {
      return this.tacoAmount;
    }

    public void Eat()
    {
      if(tacoAmount>0)
      {
        tacoAmount--;
      }
    }
  }
}