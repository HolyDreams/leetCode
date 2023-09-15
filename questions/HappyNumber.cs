using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    internal class HappyNumber
    {
        /*Задача:
          Write an algorithm to determine if a number n is happy.

          A happy number is a number defined by the following process:

          Starting with any positive integer, replace the number by the sum of the squares of its digits.
          Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
          Those numbers for which this process ends in 1 are happy.
          Return true if n is a happy number, and false if not.
         */
        public static bool IsHappy(int n)
        {
            var map = new Dictionary<int, int>()
            {
                {0, 0 },
                {1, 1 },
                {2, 4 },
                {3, 9 },
                {4, 4 * 4 },
                {5, 5 * 5 },
                {6, 6 * 6 },
                {7, 7 * 7 },
                {8, 8 * 8 },
                {9, 9 * 9 }
            };
            int count = 0;
            while (n != 1)
            {
                var mid = GetInts(n);
                long res = 0;
                for (int i = 0; i < mid.Count; i++)
                {
                    res += map[mid[i]];
                }
                if (res > int.MaxValue)
                    return false;

                n = (int)res;
                count++;
                ///7 минимальное число, с которым задача выполнилась
                if (count > 7)
                    return false;
            }
            return true;
        }
        private static List<int> GetInts(int n)
        {
            var res = new List<int>();
            while (n != 0)
            {
                res.Add(n % 10);
                n = n / 10;
            }
            return res;
        }
    }
}
