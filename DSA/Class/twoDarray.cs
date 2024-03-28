using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Class
{
    internal class twoDarray
    {
        public void matrix()
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
            int sum = 0;
            for (int i = 0;i<matrix.GetLength(0);i++)
            {
                int product = matrix[i,0];
                for(int j = 1; j < matrix.GetLength(1); j++)
                {
                    int k = matrix[i,j];
                    product *= matrix[i,j];
                }
                sum += product;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
