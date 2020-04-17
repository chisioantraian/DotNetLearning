using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLearning.Algorithms.Sorting
{
    class InsertionSort
    {
        static void Sort(List<int> A)
        {
            for (int i = 1; i < A.Count; i++)
            {
                int j = i - 1;
                while ((j >= 0) && (A[j] > A[i]))
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = A[i];
            }
        }
    }
}
