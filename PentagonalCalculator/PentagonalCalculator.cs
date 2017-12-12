using System;
namespace PentagonalNumber
{
    public class PentagonalCalculator
    {
        public ulong CalcuatePentagonalNumberOf(ulong number) 
        {
            return (number * (3 * number - 1)) / 2;
        }

        public ulong SumOfNumberAndPentagonalNumber(ulong number)
        {
            return number + CalcuatePentagonalNumberOf(number);
        }

        public ulong DiffOfPentagonalNumberAndNumber(ulong number)
        {
            return CalcuatePentagonalNumberOf(number) - number;
        }

        public bool IsPentagonal(ulong number)
        {
            return Math.Abs((Math.Sqrt(1 + 24 * number) + 1) % 6) < 0.000001;
        }

        public ulong MaxPentagonalNumber()
        {
            return (ulong)(Math.Sqrt(ulong.MaxValue) + 1) / 6;
        }

        public ulong CalculateAbsOfDiff() 
        {
            ulong Dmin = ulong.MaxValue;
            for (ulong i = MaxPentagonalNumber(); i > 0; --i)
            {
                if(IsPentagonal(i))
                {
                    ulong tempDmin = SumOfNumberAndPentagonalNumber(i) - DiffOfPentagonalNumberAndNumber(i);
                    if (tempDmin < Dmin)
                        Dmin = tempDmin;
                }
            }
            return Dmin;
        }
    }
}
