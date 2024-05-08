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
                Console.WriteLine("max numbeer = "+arr[maxNumber]);
                return arr[maxNumber];
            }
            return 0;
        }

        public int TotalSum(int[] arr)//linear
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum +=  arr[i];

            }
            return sum;
        }

        public int FindMinNumber(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int minNumber = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[minNumber])
                    {
                        minNumber = j;
                    }
                }
                Console.WriteLine("Min Number = "+arr[minNumber]);
                return arr[minNumber];
            }
            return 0;
        }

        public int MinMaxNumberSum(int[] arr)
        {
            return TotalSum(new int[] {FindMinNumber(arr),FindMaxNumber(arr)}); 
        }

        public int CompareVersionNumbers(string v1,string v2)
        {
            var version1 = new Version(v1);
            var version2 = new Version(v2);

            var result = version1.CompareTo(version2);
            if (result > 0)
                return 1;
            else if (result < 0)
                return -1;
            else
                return 0;
        }
    }
}
