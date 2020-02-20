using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter(15);
      Counter zero = new Counter();
      Console.WriteLine(counter);
      counter.Decrease(-4);
      Console.WriteLine(counter);
      counter.Increase(5);
      Console.WriteLine(counter);

      Console.WriteLine(zero);
      zero.Increase(7);
      Console.WriteLine(zero);
      zero.Increase();
      Console.WriteLine(zero);

    }
  }
}
