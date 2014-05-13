//Coditions are in the .txt file.
//Sorry 'bout the code it's quite messy, I know. Also I don't get the Idea to write a test class from ex.7 and ex.12.
//I think those "tests" are better suited for the main method.
namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    class Program
    {
        static void Main()
        {
            GSM nexus5 = new GSM("Nexus5", "LG");
            Console.WriteLine(nexus5.ToString());

            Call firstCall = new Call("+359883123123", 60);
            Call secondCall = new Call("+359883321321", 60);

        }
    }
}
