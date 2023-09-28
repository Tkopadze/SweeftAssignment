using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PalindromeChecker
    {

        public  bool IsPalindrome(string text)
        {
            // Remove special characters and convert the text to lowercase
            string cleanText = Regex.Replace(text, "[^a-zA-Z0-9]", "").ToLower();

            // Check if the cleaned text is equal to its reverse
            return cleanText == ReverseString(cleanText);
        }


        private static string ReverseString(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
