namespace Bank
{
    using System;

    class LoanAccount : Account
    {
        public LoanAccount(string customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        { }

        public override double CalculateInterest(int months)
        {
            if (Customer == "person")
            {
                if (months > 3)
                {
                    return (months - 3) * InterestRate;
                }
                else
                {
                    return 0;
                }
            }
            else 
            {
                if (months > 2)
                {
                    return (months - 2) * InterestRate;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
