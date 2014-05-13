namespace CallTest
{

    using System;
    using System.Collections.Generic;
    using MobilePhoneDevice;

    class CallTest
    {
        static void Main(string[] args)
        {
            GSM galaxyS5 = new GSM("GalaxyS5", "Samsung");

            Call firstCall = new Call("+359883123123", 60);
            Call secondCall = new Call("+359883345345", 60);

            galaxyS5.AddCall(firstCall);
            galaxyS5.AddCall(secondCall);

            decimal phoneBill = galaxyS5.CalculeteTotolPrice(0.37m);

            Console.WriteLine(phoneBill);


        }
    }
}
