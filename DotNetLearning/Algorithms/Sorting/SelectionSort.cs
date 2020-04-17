using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLearning.Algorithms.Sorting
{
    class SelectionSort
    {
        static void Sort(List<int> A)
        {
            for (int i = 0; i < A.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < A.Count; j++)
                    if (A[j] < A[minIndex])
                        minIndex = j;
                int temp = A[minIndex];
                A[minIndex] = A[i];
                A[i] = temp;
            }
        }
    }
}
