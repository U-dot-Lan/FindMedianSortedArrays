using System;
using System.Collections.Generic;
using System.Text;

namespace FindMedianSortedArrays
{
    public static class FMSA
    {
        public static double FindMedian(int[] nums1, int[] nums2)
        {
                int l1 = nums1.Length;
                int l2 = nums2.Length;
                int length = l1 + l2;
                var resultIndex = length / 2;
                List<int> list = new List<int>(nums1);
                list.AddRange(nums2);
                list.Sort();
                if (length % 2 == 0)
                {
                    return (list[resultIndex - 1] + list[resultIndex]) / 2.0;
                }
                else
                {
                    return list[resultIndex];
                }
            
        }
    }
}
