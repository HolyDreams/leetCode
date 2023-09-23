using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    internal class ContainsDuplicateII
    {
        /*Задача:
          Given an integer array nums and an integer k, return true if there are two distinct indices i and j in 
          the array such that nums[i] == nums[j] and abs(i - j) <= k.

         */
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var hash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.ContainsKey(nums[i]))
                    hash.Add(nums[i], i);
                else
                {
                    if (Math.Abs(nums[i] - i) <= k)
                        return true;

                    hash[nums[i]] = i;
                }
            }
            return false;
        }
    }
}
