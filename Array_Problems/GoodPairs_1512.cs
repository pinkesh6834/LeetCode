//using System;
//using System.Collections.Generic;

//namespace LeetCode
//{
//    class GoodPairs_1512
//    {
//        static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 3, 1, 1, 3 };
//            NumIdenticalPairs(array);
//        }

//        public static int NumIdenticalPairs(int[] nums)
//        {
//            var dict = new Dictionary<int, int>();
//            int result = 0;
//            for (int i = 0; i < nums.Length; i++)
//            {
//                if (dict.ContainsKey(nums[i]))
//                {
//                     dict[nums[i]]++;

//                }
//                else
//                {
//                    dict.Add(nums[i], 1);
//                }
//            }

//            foreach (var item in dict)
//            {
//                if (item.Value == 1)
//                    continue;
//                result += ((item.Value * (item.Value - 1)) / 2);
//            }

//            return result;
//        }
//    }
//}
