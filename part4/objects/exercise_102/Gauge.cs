using System;

namespace exercise_102
{
    public class Gauge
    {
       public int value{get; set;} 
    
    public Gauge()
    {
       this.value = value;
    }
    public void Increase()
    {
        while(value<5)
        {
            value++;
        }
    }
    public void Decrease()
    {
        while(value>0)
        {
            value--;
        }
    }
    public bool Full()
    {
        if(value==5)
        {
            return true;
        }
        return false;
    }
    }
}