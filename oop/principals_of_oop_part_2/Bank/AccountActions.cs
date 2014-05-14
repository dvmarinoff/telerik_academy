namespace Bank
{
    using System;

    public interface AccountActions
    {
        void DepositMoney(double sum);
        double CalculateInterest(int months);
    }
}
