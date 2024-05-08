using System;
using System.Runtime.ConstrainedExecution;
using DSA.Class;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region searching,sorting
            Sorting s1 = new Sorting();
            Searching ser = new Searching();
            int[] arr = { 10, 5, -25, -7, 19, -10, -60, 30, 55, -40 };
            //Console.WriteLine("max number = "+ ser.FindMaxNumber(arr));
            //Console.WriteLine("Sum of total number = "+ ser.TotalSum(arr));

            //int[] arr1 = arr;
            //Console.WriteLine("Assending Order");
            //s1.AssendingSorting(arr);
            //s1.dispArray(arr);

            //Console.WriteLine("descending Order");
            //s1.DescendingSorting(arr1);
            //s1.dispArray(arr1);
            //Console.WriteLine(ser.MinMaxNumberSum(arr));

            //s1.SelectionSort(arr);
            #endregion

            #region 2dArray
            //twoDarray twoDarray = new twoDarray();
            //twoDarray.matrix();
            #endregion

            #region SubArray
            //SubArray s = new SubArray();
            //s.PrintSubArray(new int[] {1,2,3,4});
            #endregion

            #region ReverseArray
            //twoDarray tda = new twoDarray();
            //tda.ReverseArray();
            #endregion

            #region TransportArray
            //twoDarray tw = new twoDarray();
            //tw.TransposeArray();
            #endregion

            #region TransportArray
            //twoDarray tw = new twoDarray();
            ////tw.Rotate90DegreeClockWise();
            ////tw.Rotate180DegreeClockWise();
            //tw.Rotate270DegreeClockWise();
            #endregion

            #region CompareVersion
            //Console.WriteLine(ser.CompareVersionNumbers("0.1", "1.1"));
            #endregion

            #region ReversePrefixString
            //s1.ReversePrefixOfWord("abcd", "z");
            #endregion

            #region LengthOfLastWord
            Console.WriteLine(ser.LengthofLastWord("hello world"));
            #endregion
        }
    }
}
