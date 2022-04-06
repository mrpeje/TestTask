using System;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    public class Pair
    {
        int X;
        int Y;
        public Pair(int x, int y)
        {
            X = x; Y = y;
        }
        public bool IsEqual(Pair pair)
        {
            if (this.X == pair.Y && this.Y == pair.X)
                return true;
            return false;
        }
        public void Print()
        {
            Console.WriteLine("[" + X + ":" + Y + "]");
        }
    }
    public int solution(int[] A)
    {
        List<Pair> pairs = new List<Pair>();


        for (int i = 0; i < A.Length; i++)
        {
            for (int y = 0; y < A.Length; y++)
            {
                //Console.WriteLine("[" + i + ":" + y + "]");

                if (i != y && PairComp(i, A[i], y, A[y]) == true)
                {
                    Pair newPair = new Pair(i, y);
                    pairs.Add(newPair);
                    //newPair.Print();
                }
            }
        }

        // Исключить из расчёта повторные пары, например [0,1] и [1,0]
        for (int i = 0; i < pairs.Count; i++)
        {
            for (int y = 0; y < pairs.Count; y++)
            {
                if (y != i && pairs[i].IsEqual(pairs[y]) == true)
                    pairs.RemoveAt(y);
            }
        }
        /*for (int i = 0; i < pairs.Count; i++)
        {

            pairs[i].Print();
        }*/
        if (pairs.Count > 10000000)
            return -1;
        return pairs.Count;
    }
    bool PairComp(int Center1, int Value1, int Center2, int Value2)
    {
        int size1 = Value1 * 2 + 1;
        int size2 = Value2 * 2 + 1;
        int[] I = new int[size1];
        int[] J = new int[size2];

        for (int i = 0; i < I.Length; i++)
        {
            I[i] = Center1 - Value1 + i;
        }
        for (int i = 0; i < J.Length; i++)
        {
            J[i] = Center2 - Value2 + i;
        }
        for (int i = 0; i < I.Length; i++)
        {
            for (int j = 0; j < J.Length; j++)
            {
                if (I[i] == J[j])
                    return true;
            }
        }
        return false;
    }
}
