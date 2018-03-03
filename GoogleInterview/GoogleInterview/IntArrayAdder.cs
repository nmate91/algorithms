using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleInterview
{
    public class IntArrayAdder
    {
        /// <summary>
        /// Works with only adding 1
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="lastValueToWatch"></param>
        /// <returns></returns>
        public int[] AddOne(int[] numbers, int lastValueToWatch)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }
            if (numbers.Length == 0)
            {
                return numbers;
            }
            if (lastValueToWatch < 0)
            {
                var tempNumbers = new int[numbers.Length + 1];
                tempNumbers[0] = 1;
                numbers.CopyTo(tempNumbers, 1);
                numbers = tempNumbers;
                return numbers;
            }
            else if (numbers[lastValueToWatch] != 9)
            {
                ++numbers[lastValueToWatch];
                return numbers;
            }
            numbers[lastValueToWatch] = 0;
            return AddOne(numbers, --lastValueToWatch);
        }
    }
}
