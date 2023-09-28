using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        public bool IsProperly(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in sequence)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false; // Unmatched closing bracket
                    }

                    char openBracket = stack.Pop();

                    if (!IsMatching(openBracket, ch))
                    {
                        return false; // Mismatched brackets
                    }
                }
            }

            return stack.Count == 0; // Check if all brackets are matched
        }

        private bool IsMatching(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '[' && close == ']') ||
                   (open == '{' && close == '}');
        }
    }

      

}
