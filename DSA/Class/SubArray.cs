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
            for (int i = 0; i < l; i++)
            {
                for (int j = i; j < l; j++)
                {
                    for(int k = i; k <= j;k++)
                        Console.Write(arr1[k] + " ");
                    Console.WriteLine();
                }
                cnt++;
                Console.WriteLine();
            }
        }
    }
}
