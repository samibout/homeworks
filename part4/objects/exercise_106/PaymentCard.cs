using System;

namespace exercise_106
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
    }
}