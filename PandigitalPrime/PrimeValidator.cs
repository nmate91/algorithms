using System;
namespace PandigitalPrime
{
    public static class PrimeValidator
    {
        public static bool IsPrime(long number)
        {
            for (long i = 2; i < Math.Sqrt(number) + 1; ++i) 
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
