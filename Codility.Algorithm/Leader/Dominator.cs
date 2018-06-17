using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Algorithm.Leader
{
    public partial class Solution
    {
        public int Dominator(int[] A)
        {
            int? value = null;
            int size = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (size == 0)
                {
                    size++;
                    value = A[i];
                }
                else
                {
                    if (value != A[i])
                    {
                        size--;
                    }
                    else
                    {
                        size++;
                    }
                }
            }



            if (size > 0)
            {
                int index = -1;
                int count = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] == value.Value)
                    {
                        index = i;
                        count++;
                    }
                }

                if (count > A.Length / 2)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
