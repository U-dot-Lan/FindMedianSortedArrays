using System;

namespace FindMedianSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };
            double result = FMSA.FindMedian(nums1, nums2);
            Console.WriteLine(result);

            int[] nums3 = new int[] { 1, 2 };
            int[] nums4 = new int[] { 3, 4 };
            double result1 = FMSA.FindMedian(nums3, nums4);
            Console.WriteLine(result1);

        }
    }
}
