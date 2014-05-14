namespace Bank
{
    using System;

    class DepositAccount : Account
    {
        public DepositAccount(string customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        { }

        public void WithDrawMoney(double withDrownMoney)
        {
            this.Balance -= withDrownMoney;
        }

        public override double CalculateInterest(int months)
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0;
            }
            else
            {
                return months * InterestRate;
            }
        }
    }
}
