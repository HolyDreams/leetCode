using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    internal class IsomorphicStrings
    {
        /* Задача:
           Given two strings s and t, determine if they are isomorphic.

           Two strings s and t are isomorphic if the characters in s can be replaced to get t.

           All occurrences of a character must be replaced with another character while preserving
           the order of characters. No two characters may map to the same character, but a character may map to itself.
        */
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var hash = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!hash.ContainsKey(s[i]))
                {
                    if (hash.ContainsValue(t[i]))
                        return false;

                    hash.Add(s[i], t[i]);
                }
                else if (hash[s[i]] != t[i])
                    return false;
                
            }

            return true;
        }
    }
}
