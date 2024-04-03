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
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int product = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    int k = matrix[i, j];
                    product *= matrix[i, j];
                }
                sum += product;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public void ReverseArray()
        {
            int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int start = 0;
                int end = matrix.GetLength(1) - 1;
                for (int col = start; col < matrix.GetLength(1) - 1; col++)
                {
                    if (end > start)
                    {
                        int temp = matrix[row, end];
                        matrix[row, end] = matrix[row, col];
                        matrix[row, col] = temp;
                        end--;
                        start++;
                    }
                    Console.Write(matrix[row, col]);
                }
            }
        }

        public void TransposeArray()
        {
            int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 }, { 17, 18, 19, 20 } };
            int row, column, i, j;
            row = matrix.GetLength(1);
            column = matrix.GetLength(0);
            int[,] output = new int[row, column];
            for (i = 0; i < column - 1; i++)
            {
                for (j = 0; j <= row; j++)
                {
                    output[i, j] = matrix[j, i];
                    Console.Write(output[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
