using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSupport
{
    public static class StringExtension
    {
        public static string FullyCapitalize(this string value)
        {
            string output = "";
            foreach (var item in value.Split(' '))
            {
                output += item.Capitalize() + " ";
            }
            return output;
        }

        public static string Capitalize(this string value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1).ToLower();
        }
    }
}
