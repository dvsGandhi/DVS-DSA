using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Class
{
    class Sorting
    {
        public void AssendingSorting(int[] arr)//selection
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int minNum = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[minNum])
                    {
                        minNum = j;
                    }
                }
                int temp = arr[minNum];
                arr[minNum] = arr[i];
                arr[i] = temp;
            }
        }

        public void dispArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public void DescendingSorting(int[] arr)//selection
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int maxNum = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] > arr[maxNum])
                    {
                        maxNum = j;
                    }
                }
                int temp = arr[maxNum];
                arr[maxNum] = arr[i];
                arr[i] = temp;
            }
        }

        public void SelectionSort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int min_ind = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[min_ind])
                        min_ind = j; 
                }
                int temp = arr[min_ind];
                arr[min_ind] = arr[i];
                arr[i] = temp;
            }
            dispArray(arr);
        }
    }
}
