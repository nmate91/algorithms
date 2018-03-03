using GoogleInterview;
using System;
using Xunit;

namespace GoogleInterviewTests
{
    public class Test_IntArrayHandler
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 4, 2 })]
        [InlineData(new int[] { 1, 1, 4, 6 })]
        public void CreatesNumberFromArray_ExpectTrue(int[] numberArray)
        {
            IntArrayHandler repr = new IntArrayHandler();
            Assert.IsType<int>(repr.CreateIntFromArray(numberArray));
        }

        [Theory]
        [InlineData(4, new int[] { 1, 3, 4, 2 })]
        [InlineData(3, new int[] { 1, 1, 4 })]
        public void CompareArrayAndNumberLenght_ExpectEqual(int length, int[] numberArray)
        {
            IntArrayHandler repr = new IntArrayHandler();
            Assert.Equal(length, repr.CreateIntFromArray(numberArray).ToString().Length);
        }

        [Theory]
        [InlineData(1342, new int[] { 1, 3, 4, 2 })]
        [InlineData(1146, new int[] { 1, 1, 4, 6 })]
        [InlineData(9999, new int[] { 9, 9, 9, 9 })]
        public void CreatesTheCorrectNumber_ExpectEqual(int number, int[] numberArray)
        {
            IntArrayHandler repr = new IntArrayHandler();
            Assert.Equal(number, repr.CreateIntFromArray(numberArray));
        }

        [Theory]
        [InlineData(1343, new int[] { 1, 3, 4, 2 })]
        [InlineData(1147, new int[] { 1, 1, 4, 6 })]
        [InlineData(10000, new int[] { 9, 9, 9, 9 })]
        public void AddOneToRepresentedNumber_ExpectEqual(int number, int[] numberArray)
        {
            IntArrayHandler repr = new IntArrayHandler();
            Assert.Equal(number, repr.AddOne(numberArray));
        }

        [Fact]
        public void ThrowsExceptionIfArrayIsEmpty_ExpectTrue()
        {
            IntArrayHandler repr = new IntArrayHandler();
            Func<object> func = () => 
            {
                return repr.AddOne(new int[] { });
            };
            Assert.Throws<ArgumentNullException>(func);
        }
    }
}
