using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLearning.Algorithms.Searching
{
    class Sequential
    {
        /*
         * return the position where val is found
         */
        static int Search(List<int> nums, int val)
        {
            for (int i = 0; i < nums.Count; i++)
                if (nums[i] == val)
                    return i;
            return -1;
        }
    }
}
