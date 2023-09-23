using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.questions
{
    /* Задача:
       Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.
     */
    internal class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            List<int[]> result = new List<int[]>();
            int min = intervals[0][0]; 
            int max = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] > max)
                {
                    result.Add(new int[] { min, max });
                    min = intervals[i][0];
                    max = intervals[i][1];
                }
                else
                    max = intervals[i][1];
                if (intervals[i][0] < min)
                    min = intervals[i][0];
            }

            result.Add(new int[] { min, max });
            return result.ToArray();
        }
    }
}
