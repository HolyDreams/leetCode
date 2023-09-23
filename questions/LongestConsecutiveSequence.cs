using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    /*Задача:
       Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

       You must write an algorithm that runs in O(n) time.
    */
    internal class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            Array.Sort(nums);
            if (nums.Length <= 1)
                return nums.Length;
            var hash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.ContainsKey(nums[i]))
                    hash.Add(nums[i], hash.ContainsKey(nums[i] - 1) ? hash[nums[i] - 1] + 1: 1);
            }
            return hash.Max(a => a.Value);
        }
    }
}
