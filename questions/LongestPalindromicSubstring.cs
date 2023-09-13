using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    internal class LongestPalindromicSubstring
    {
        /*Задача:
        Given a string s, return the longest palindromic substring in s.
        */
        public static string LongestPalindrome(string s)
        {
            if (s.Length == 1)
                return s;

            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (result.Length > s.Length - i)
                    return result;
                for (int j = s.Length; j > i; j--)
                {
                    if (s[j - 1] != s[i])
                        continue;
                    else if (j - i <= result.Length)
                        break;
                    var text = s.Substring(i).Remove(j - i).ToString();
                    var textRevers = new String(text.Reverse().ToArray());
                    if (text == textRevers && text.Length > result.Length)
                        result = text;
                }
            }
            return result;
        }
    }
}
