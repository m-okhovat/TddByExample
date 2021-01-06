﻿namespace TddByExample.Domain
{
    public abstract class Money
    {
        protected int Amount { get; set; }

        protected Money(int amount)
        {
            Amount = amount;
        }

        public override bool Equals(object? obj)
        {

            return Amount == ((Money)obj).Amount && obj.GetType() == GetType();
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
        }

        public abstract Money Times(int multiplyBy);


        public abstract string Currency();
    }
}