using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLearning.Algorithms.Sorting
{
    class MergeSort
    {
        public static void Sort(List<int> A)
        {
            mergeSort(A, 0, A.Count - 1);
        }

        static void mergeSort(List<int> A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                mergeSort(A, left, mid);
                mergeSort(A, mid + 1, right);
                merge(A, left, mid, right);
            }
        }

        static void merge(List<int> A, int left, int mid, int right)
        {
            int i1 = left;
            int i2 = mid;
            int i3 = 0;
            int[] tmp = new int[(right - left) + 1];

            while ((i1 <= mid) && (i2 <= right))
            {
                if (A[i1] < A[i2])
                {
                    tmp[i3] = A[i1];
                    i1++;
                }
                else
                {
                    tmp[i3] = A[i2];
                    i2++;
                }
                i3++;
            }

            while (i1 <= mid)
            {
                tmp[i3] = A[i1];
                i1++;
                i3++;
            }
            while (i2 <= right)
            {
                tmp[i3] = A[i2];
                i2++;
                i3++;
            }

            for (int i = 0; i < tmp.Length; i++)
                A[left + i] = tmp[i];
        }
    }
}
