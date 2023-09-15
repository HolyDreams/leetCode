using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    internal class WordPattern
    {
        /* Задача:
           Given a pattern and a string s, find if s follows the same pattern.

           Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
        */
        public static bool _wordPattern(string pattern, string s)
        {
            var hash = new Dictionary<char, string>();
            var splitString = s.Split(' ');
            for (int i = 0; i < pattern.Length; i++)
            {
                if (hash.ContainsKey(pattern[i])) 
                {
                    if (hash.GetValueOrDefault(pattern[i]) != splitString[i])
                        return false;
                }
                else if (hash.ContainsValue(splitString[i]))
                    return false;
                else
                    hash.Add(pattern[i], splitString[i]);
            }
            return true;
        }
    }
}
