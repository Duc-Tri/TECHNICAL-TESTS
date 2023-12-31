﻿using System;

namespace Codility_Tests
{
    public static class L02_Arrays
    {
        // Find value that occurs in odd number of elements
        public static int OddElement(int[] A)
        {
            if (A.Length == 1) return A[0];

            Array.Sort(A);
            int previous = A[A.Length - 1];
            for (int i = A.Length - 2; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    if (A[i] != previous) return previous;
                }
                else
                    previous = A[i];
            }

            return -1; // error !
        }

        // Rotate an array to the right by a given number of steps
        public static int[] CyclicRotation(int[] A, int K)
        {
            if (A != null && A.Length > 1 && K > 0)
            {
                for (int t = 0; t < K; t++)
                {
                    int last = A[A.Length - 1];
                    for (int i = A.Length - 2; i >= 0; i--)
                    {
                        int temp = A[i + 1];
                        A[i + 1] = A[i];
                    }
                    A[0] = last;
                }
            }

            return A;
        }
    }
}


