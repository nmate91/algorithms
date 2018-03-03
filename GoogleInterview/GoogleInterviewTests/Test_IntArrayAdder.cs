using GoogleInterview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace GoogleInterviewTests
{
    public class Test_IntArrayAdder
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 4, 3 }, new int[] { 1, 3, 4, 2 })]
        [InlineData(new int[] { 1, 1, 4, 7 }, new int[] { 1, 1, 4, 6 })]
        [InlineData(new int[] { 8, 8, 9, 0 }, new int[] { 8, 8, 8, 9 })]
        [InlineData(new int[] { 1, 0, 0, 0, 0 }, new int[] { 9, 9, 9, 9 })]
        public void AddsOne_Success(int[] expectedResult, int[] numbers)
        {
            IntArrayAdder adder = new IntArrayAdder();
            Assert.Equal(expectedResult, adder.AddOne(numbers, numbers.Length - 1));
        }
    }
}
