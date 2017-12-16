using System;
namespace PandigitalPrime
{
    public class PandigitalPrimeValidator
    {
        const long maxPandigital = 9876543210;

        public bool DivisableByThree(long number)
        {
            int sumOfDigits = 0;
            string sNumber = number.ToString();
            foreach (char c in sNumber)
            {
                sumOfDigits += int.Parse(c.ToString());
            }
            return sumOfDigits % 3 == 0;
        }

        public long GetNextMaxPandigital(long number)
        {
            string sNumber = String.Empty;
            int count = number.ToString().Length;
            for (int i = count - 2; i >= 0; i--)
            {
                sNumber += i.ToString();
            }
            return long.Parse(sNumber);
        }

        public long GetMaxPandigitalPrime()
        {
            long i = maxPandigital;
            while(i > 0)
            {
                if (PandigitalValidator.IsPandigital(i))                 
                {
                    if(DivisableByThree(i))
                    {
                        i = GetNextMaxPandigital(i);
                        continue;
                    }
                    if (PrimeValidator.IsPrime(i)) 
                        return i;
                }
                --i;
            }
            return -1;
        }
    }
}
