using System;

namespace exercise_108
{
    public class PaymentCard
    {
        private double balance = 0.0;

        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        }
        public override string ToString()
        {
            return "The card has a balance of " + this.balance + " euros";
        }
        public void EatLunch()
        {
            if(this.balance>=10.60)
            {
                this.balance = this.balance - 10.60;
            }
        }
        public void DrinkCoffee()
        {
            if(this.balance>=2.00)
            {
                this.balance = this.balance - 2.00;
            }    
        }
        
    }
}