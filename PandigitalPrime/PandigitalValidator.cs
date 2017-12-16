using System;
using System.Collections.Generic;
using System.Linq;
namespace PandigitalPrime
{
    public static class PandigitalValidator
    {
        public static bool IsPandigital(long number)
        {
            string temp = String.Empty;
            string sNumber = number.ToString();
            foreach (var c in sNumber)
            {
                int digit = int.Parse(c.ToString());
                if (digit >= sNumber.Length)
                    return false;
                if (!temp.Contains(c))
                    temp += c;
                else
                    return false;
            }
            return true;
        }
    }
}
