using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLearning.Algorithms.Sorting
{
    class BubbleSort
    {
        static void Sort(List<int> A)
        {
            bool isSorted;
            do
            {
                isSorted = true;
                for (int i = 1; i < A.Count; i++)
                    if (A[i-1] > A[i])
                    {
                        int temp = A[i - 1];
                        A[i - 1] = A[i];
                        A[i] = temp;
                        isSorted = false;
                    }

            } while (!isSorted);
        }

        static void SortOptimized(List<int> A)
        {
            bool isSorted;
            int s = 0;
            do
            {
                isSorted = true;
                for (int i = 1; i < A.Count - s; i++)
                    if (A[i - 1] > A[i])
                    {
                        int temp = A[i - 1];
                        A[i - 1] = A[i];
                        A[i] = temp;
                        isSorted = false;
                    }
                s++;
            } while (!isSorted);
        }

    }
}
