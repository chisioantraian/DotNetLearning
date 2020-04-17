using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLearning.Algorithms.Searching
{
    class Binary
    {
        static int Search(List<int> nums, int val)
        {
            return BSearch(nums, val, 0, nums.Count);
        }

        private static int BSearch(List<int> nums, int val, int left, int right)
        {
            if (left > right)
                return -1;
            int m = (left + right) / 2;
            if (nums[m] == val)
                return m;
            else if (nums[m] < val)
                return BSearch(nums, val, m + 1, right);
            else
                return BSearch(nums, val, left, m - 1);
        }

        private static int BSearchIterativ(List<int> nums, int val)
        {
            int left = 0;
            int right = nums.Count;
            while (left <= right)
            {
                int m = (left + right) / 2;
                if (val == nums[m])
                    return m;
                else if (val < nums[m])
                    right = m - 1;
                else
                    left = m + 1;
            }
            return -1;
        }
    }
}
