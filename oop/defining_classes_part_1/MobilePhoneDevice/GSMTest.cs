namespace MobilePhoneDevice
{

    using System;
    using System.Collections.Generic;

    public class GSMTest
    {
        public static void Test()
        {
            GSM[] shelf = new GSM[0];

            GSM firstPhone = new GSM("nexus5", "LG");
            GSM secondPhone = new GSM("GalaxyS4", "Samsung");
            GSM thirdPhone = new GSM("iPhoneS5", "Apple");

            shelf[0] = firstPhone;
            shelf[1] = secondPhone;
            shelf[2] = thirdPhone;

            foreach (var phone in shelf)
            {
                phone.ToString();
            }

            Console.WriteLine(GSM.IPhoneS4.ToString());
        }

    }
}
