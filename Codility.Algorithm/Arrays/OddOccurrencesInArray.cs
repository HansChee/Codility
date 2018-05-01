/**
 * https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.Algorithm.Arrays
{
    public partial class Solution
    {
        public static int OddOccurrencesInArray(int[] A)
        {
            if (A.Length == 1)
            {
                return A[0];
            }
            var listA = A.ToList();
            listA.Sort();
            for (int i = 0; i < listA.Count; i++)
            {
                if (i < listA.Count - 1 && listA[i] == listA[i + 1])
                {
                    i++;
                }
                else
                {
                    return listA[i];
                }
            }
            throw new Exception("This is not a valid array");
        }
    }
}
