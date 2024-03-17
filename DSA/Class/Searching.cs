using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Class
{
    class Searching
    {
        public int FindMaxNumber(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int maxNumber = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] > arr[maxNumber])
                    {
                        maxNumber = j;
                    }
                }
                return arr[maxNumber];
            }
            return 0;
        }
    }
}
