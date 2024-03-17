using System;
using DSA.Class;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting s1 = new Sorting();
            Searching ser = new Searching();
            int[] arr = { 10, 5, -25, -7, 19, -10, -60, 30, 55, -40 };
            Console.WriteLine("max number = "+ ser.FindMaxNumber(arr));
            s1.AssendingSorting(arr);
            s1.dispArray(arr);
            
            Console.WriteLine("Hello World!");
        }
    }
}
