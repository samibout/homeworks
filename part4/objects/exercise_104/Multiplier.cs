using System;

namespace exercise_104
{
    public class Multiplier
    {
        public int number{get;set;}

        public Multiplier(int number)
        {
            this.number = number;
        }
        public int Multiply(int number)
        {
            return this.number * number;
        }
    }
}