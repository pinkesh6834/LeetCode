using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Array
{
    class CountSmallerNumbers_1365
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 1, 2, 2, 3 }; // 1,2,2,3,8
            SmallerNumbersThanCurrent(array);
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            var dict = new Dictionary<int, int>();
            var pointer = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[pointer] - nums[i] > 0) {
                    if (dict.ContainsKey(nums[pointer]))
                    {
                        dict[nums[pointer]]++;
                    }
                    else {
                        dict[nums[pointer]] = 1;
                    }
                }
            }
        }
    }
}
