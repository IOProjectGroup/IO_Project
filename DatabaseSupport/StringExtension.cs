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
            value = value.Replace("  ", " ");
            string output = "";
            foreach (var item in value.Split(' '))
            {
                output += item.Capitalize() + " ";
            }
            return output;
        }

        public static string Capitalize(this string value)
        {
            value = value.Replace("  ", " ");
            string output = "";
            try
            {
                output += value.Substring(0, 1).ToUpper();
            }
            catch (Exception)
            {
                output += value.ToUpper();
                return output;
            }

            try
            {
                output += value.Substring(1, value.Length - 1).ToLower();
            }
            catch (Exception)
            {
            }
            return output;
        }
    }
}
