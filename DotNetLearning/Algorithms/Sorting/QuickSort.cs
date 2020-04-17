using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLearning.Algorithms.Sorting
{
    class QuickSort
    {
        static void quickSort(List<int> A)
        {
            Quick(A, 0, A.Count - 1);
        }

        private static void Quick(List<int> A, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(A, left, right);
                Quick(A, left, pivot - 1);
                Quick(A, pivot + 1, right);
            }
        }

        private static int Partition(List<int> A, int left, int right)
        {
            int pivot = A[left]; // pivot value
            while (true)
            {
                while (A[left] < pivot)
                    left++;
                while (A[right] > pivot)
                    right--;
                if (left >= right)
                    return right;
                int temp = A[left];
                A[left] = A[right];
                A[right] = temp;
            }
        }

    }
}
