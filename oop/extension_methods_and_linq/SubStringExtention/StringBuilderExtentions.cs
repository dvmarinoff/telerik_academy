namespace SubStringExtention
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class StringBuilderExtentions
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            return new StringBuilder(input.ToString().Substring(startIndex, length));
        }
    }
}
