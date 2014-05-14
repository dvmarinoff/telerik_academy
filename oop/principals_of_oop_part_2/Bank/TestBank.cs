namespace Bank
{
    using System;

    class TestBank
    {
        static void Main()
        {

            Account[] accounts = {
                                     new DepositAccount("company", 200.0, 0.5),
                                     new DepositAccount("person", 20.0, 0.3),
                                     new LoanAccount("company",400.0, 0.7),
                                     new LoanAccount("person",40.0, 0.5),
                                     new LoanAccount("company", 1000.0, 1.9),
                                     new LoanAccount("person", 800.0, 1.2)
                                 };

            foreach (var account in accounts)
            {
                Console.WriteLine(account.CalculateInterest(20));
            }

            Console.WriteLine(new string('-', 40));

            Console.WriteLine(accounts[0].Balance);
            accounts[0].DepositMoney(5000d); 
            Console.WriteLine(accounts[0].Balance);
        }
    }
}
