using System;
using DSA.Class;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting s1 = new Sorting();
            int[] arr = { 10, 5, -25, -7, 19, 2, -10 };
            s1.AssendingSorting(arr);
            s1.dispArray(arr);
            Console.WriteLine("Hello World!");
        }
    }
}
