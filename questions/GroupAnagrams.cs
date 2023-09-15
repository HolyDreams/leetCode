using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    internal class GroupAnagrams
    {
        /*Задача:
          Given an array of strings strs, group the anagrams together. You can return the answer in any order.

          An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
         */

        public static IList<IList<string>> groupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();
            var hash = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                var array = strs[i].ToArray();
                Array.Sort(array);
                var str = new String(array);
                if (hash.ContainsKey(str))
                {
                    hash[str].Add(strs[i]);
                }
                else
                    hash.Add(str, new List<string>() { strs[i] });
            }
            result.AddRange(hash.Values);
            return result;
        }
    }
}
