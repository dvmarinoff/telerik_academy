namespace SubStringExtention
{
    using System;
    using System.Collections.Generic;
    using System.Text;
   
    class StringBuilderExtentionTest
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello World!");

            Console.WriteLine(sb.Substring(0, 5));
        }
    }
}
