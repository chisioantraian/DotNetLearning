using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetLearning.Algorithms
{
    class Interclasare
    {
        static List<int> Interclaseaza(List<int> A, List<int> B)
        {
            List<int> C = new List<int>();
            int i = 0, j = 0;

            while ((i < A.Count) && (j < B.Count))
            {
                if (A[i] < B[j])
                {
                    C.Add(A[i]);
                    i++;
                }
                else
                {
                    C.Add(B[j]);
                    j++;
                }
            }
            while (i < A.Count)
            {
                C.Add(A[i]);
                i++;
            }
            while (i < B.Count)
            {
                C.Add(B[j]);
                j++;
            }
            
            return C;
        }
    }
}
