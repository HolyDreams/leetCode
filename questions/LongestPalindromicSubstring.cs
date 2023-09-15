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
                var subRes = sub(s, i, i);
                if (subRes.Length > result.Length)
                {
                    result = subRes;
                }

                subRes = sub(s, i, i + 1);
                if (subRes.Length > result.Length)
                {
                    result = subRes;
                }
            }
            return result;
        }
        private static string sub(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return s.Substring(left + 1, right - left - 1);
        }
    }
}
