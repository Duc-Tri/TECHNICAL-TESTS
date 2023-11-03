﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Tests
{
    public static class L02_Arrays
    {
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

    }

}