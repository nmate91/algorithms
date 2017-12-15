using System;
using System.Diagnostics;

namespace PentagonalNumber
{
    public class PentagonalCalculator
    {
        public ulong CalcuatePentagonalNumberOf(ulong number) 
        {
            return number * (3 * number - 1) / 2;
        }

        public ulong SumOfNumberAndPentagonalNumber(ulong number)
        {
            return number + CalcuatePentagonalNumberOf(number);
        }

        public ulong DiffOfPentagonalNumberAndNumber(ulong number)
        {
            return CalcuatePentagonalNumberOf(number) - number;
        }

        public bool IsUlong(double number)
        {
            return (1 + 24 * number) % 1 < double.Epsilon;
        }

        public bool IsPentagonal(ulong number)
        {
            return (Math.Sqrt(1 + 24 * number) + 1) % 6 < double.Epsilon;
        }

        public ulong MaxPentagonalNumber()
        {
            return (ulong)(Math.Sqrt(ulong.MaxValue) + 1) / 6;
        }

        public ulong CalculateAbsOfDiff() 
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (ulong i = 1; i < ulong.MaxValue; ++i)
            {
                ulong n = CalcuatePentagonalNumberOf(i);

                for (ulong j = i - 1; j > 0; j--)
                {
                    ulong m = CalcuatePentagonalNumberOf(j);
                    if (IsPentagonal(n - m) && IsPentagonal(n + m))
                    {
                        return n - m;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            return 0;
        }
    }
}
