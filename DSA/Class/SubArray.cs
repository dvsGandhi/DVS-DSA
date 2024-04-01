using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Class
{
    internal class SubArray
    {
        public void PrintSubArray(int[] arr1)
        {
            List<int> list = new List<int>();
            int cnt = 0;
            int l = arr1.Length;
            for (int start = 0; start < l; start++)
            {
                for (int end = start; end < l; end++)
                {
                    for(int element = start; element <= end;element++)
                        Console.Write(arr1[element] + " ");
                    Console.WriteLine();
                }
                cnt++;
                Console.WriteLine();
            }
        }
    }
}
