using System;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] A)
    {
        int Count = 0;

        for (int i = 0; i < A.Length; i++)
        {
            for (int y = 1 + i; y < A.Length; y++)
            {
                if (PairComp(i, A[i], y, A[y]) == true)
                {
                    Count++;
                }
            }
        }

        if (Count > 10000000)
            return -1;
        return Count;
    }
    bool PairComp(int Center1, int Value1, int Center2, int Value2)
    {
        long Imax, Jmin;

        Imax = (long)Center1 + (long)Value1;
        Jmin = (long)Center2 - (long)Value2;

        if (Imax >= Jmin)
            return true;

        return false;
    }
}
