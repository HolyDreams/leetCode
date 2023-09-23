using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    /* Задача:
        You are given a sorted unique integer array nums.

        A range [a,b] is the set of all integers from a to b (inclusive).

        Return the smallest sorted list of ranges that cover all the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.

        Each range [a,b] in the list should be output as:

        "a->b" if a != b
        "a" if a == b
     */
    internal class SummaryRanges
    {
        public static IList<string> _SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();
            Dictionary<int, int> hash = new Dictionary<int, int>();
            int lastInd = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.ContainsValue(nums[i] - 1))
                {
                    hash.Add(nums[i], nums[i]);
                    lastInd = nums[i];
                }
                else
                {
                    hash[lastInd]++;
                }
            }
            foreach (var item in hash)
            {
                if (item.Key == item.Value)
                    result.Add(item.Key.ToString());
                else
                    result.Add(item.Key + "->" + item.Value);
            }
            return result;
        }
    }
}
