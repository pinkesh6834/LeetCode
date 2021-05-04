using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class CountSmallerNumbers_1365
    {
        static void Main(string[] args)
        {
            int[] array = { 2,4,5,3,2,1 };

            SmallerNumbersThanCurrent(array);
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]].Add(i);
                }
                else
                {
                    dict[nums[i]] = new List<int> { i };
                }
            }

            List<int> sortedList = nums.ToList();
            sortedList.Sort();

            var counter = int.MinValue;
            var result = new int[nums.Length];


            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && sortedList[i] == sortedList[i - 1])
                {
                    if (dict[sortedList[i]].Count() < 2)
                    {
                        result[dict[sortedList[i]].First()] = i - counter;
                        counter++;
                    }
                    else
                    {
                        result[dict[sortedList[i]].First()] = i - counter;
                        dict[sortedList[i]].RemoveAt(0);
                        counter++;
                    }
                }
                else
                {
                    counter = 1;
                    result[dict[sortedList[i]].First()] = i;
                    dict[sortedList[i]].RemoveAt(0);
                }
            }

            return result;
        }
    }
}
