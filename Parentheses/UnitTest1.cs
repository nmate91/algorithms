using System;
using Xunit;

namespace Parentheses
{
    public class UnitTest1
    {
        [Fact]
        public void ValidateParentheses()
        {
            ParenthesesValidator validator = new ParenthesesValidator();
            string text = "j4dsads3(d3)((__)){{{{{dsadsa}}dsad}}}[]";
            Assert.True(validator.ValidateParentheses(text));
        }

        [Fact]
        public void Test_IsRightParentheses()
        {
            ParenthesesValidator validator = new ParenthesesValidator();
            char c = ']';
            Assert.True(validator.IsRightParentheses(c));
            c = '[';
            Assert.False(validator.IsRightParentheses(c));
        }

        [Fact]
        public void Test_IsLeftParentheses()
        {
            ParenthesesValidator validator = new ParenthesesValidator();
            char c = '{';
            Assert.True(validator.IsLeftParentheses(c));
            c = 's';
            Assert.False(validator.IsLeftParentheses(c));
        }

        [Fact]
        public void Test_GetLeftPairOf()
        {
            ParenthesesValidator validator = new ParenthesesValidator();
            char c = '}';
            Assert.Equal(validator.GetLeftPairOf(c), '{');
            c = 'c';
            Assert.Equal(validator.GetLeftPairOf(c), ' ');
        }
    }
}
