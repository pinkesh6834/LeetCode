//using System;

//namespace LeetCode
//{
//    class ShuffleArray_1470
//    {
//        static void Main(string[] args)
//        {
//            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            Shuffle(array, 5);
//        }

//        public static int[] Shuffle(int[] arr, int n)
//        {
//            if (arr.Length == 2) {
//                return arr;
//            }

//            int[] result = new int[arr.Length];
//            result[0] = arr[0];
//            result[9] = arr[9];
//            int j = n;
//            int k = 1;

//            for (int i = 1; i < 2 * n - 1; i++)
//            {
//                if (i % 2 != 0)
//                {
//                    result[i] = arr[j];
//                    j++;
//                }
//                else
//                {
//                    result[i] = arr[k];
//                    k++;
//                }
//            }

//            return result;
//        }
//    }
//}
