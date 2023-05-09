using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_ObjectorientedPractice
{
    public class RowofMatrix
    {
        public void MatrixRow()
        {
             int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
              };

                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    int rowSum = 0;
                    for (int j = 0; j < cols; j++)
                    {
                        rowSum += matrix[i, j];
                    }
                    Console.WriteLine("Sum of row " + i + ": " + rowSum);
                }
        }

    }
}
