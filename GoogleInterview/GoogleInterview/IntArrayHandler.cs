using System;
using System.Linq;

namespace GoogleInterview
{
    public class IntArrayHandler
    {
        public int CreateIntFromArray(int[] numberArray, int number = 0)
        {
            if (numberArray.Length == 0) return number;
            int currentNumber = numberArray[0] * (int)Math.Pow(10, numberArray.Length - 1) + number;
            return CreateIntFromArray(numberArray.Skip(1).ToArray(), currentNumber);
        }

        public int AddOne(int[] numberArray)
        {
            if (numberArray.Length == 0)
            {
                throw new ArgumentNullException("Cannot pass empty array");
            }
            
            return CreateIntFromArray(numberArray) + 1;
        }
    }
}
