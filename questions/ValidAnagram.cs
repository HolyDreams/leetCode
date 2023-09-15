using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    internal class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            /* Задача:
               Given two strings s and t, return true if t is an anagram of s, and false otherwise.

               An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
               typically using all the original letters exactly once.
            */

            // Вариант через массивы.
            var sArray = s.ToArray();
            var tArray = t.ToArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            return Enumerable.SequenceEqual(sArray, tArray);
            

            // Вариант через хэшмап.
            if (s.Length != t.Length) return false;

            var hash = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (hash.ContainsKey(s[i]))
                    hash[s[i]] += 1;
                else
                    hash.Add(s[i], 1);

                if (hash.ContainsKey(t[i]))
                    hash[t[i]] -= 1;
                else
                    hash.Add(t[i], -1);
            }

            return !hash.Any(a => a.Value != 0);
        }
    }
}
