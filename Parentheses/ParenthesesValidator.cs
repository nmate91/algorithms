using System;
using System.Collections.Generic;

namespace Parentheses
{
    public class ParenthesesValidator
    {
        public bool ValidateParentheses(string text)
        {
            Stack<char> parenthesStack = new Stack<char>();
            foreach (char c in text)
            {
                if (IsLeftParentheses(c))
                {
                    parenthesStack.Push(c);
                }
                else if(IsRightParentheses(c))
                {
                    if (parenthesStack.Pop() != GetLeftPairOf(c))
                        return false;
                }
            }
            return parenthesStack.Count == 0;
        }

        internal char GetLeftPairOf(char c)
        {
            if (')' == c) return '(';
            if (']' == c) return '[';
            if ('}' == c) return '{';
            return ' ';
        }

        internal bool IsLeftParentheses(char c) 
        {
            if ('(' == c) return true;
            if ('[' == c) return true;
            if ('{' == c) return true;
            return false;
        }

        internal bool IsRightParentheses(char c)
        {
            if (')' == c) return true;
            if (']' == c) return true;
            if ('}' == c) return true;
            return false;
        }
    }
}
