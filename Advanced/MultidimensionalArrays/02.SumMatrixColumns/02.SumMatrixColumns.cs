﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];
            
            for (int col = 0; col < cols; col++)
            {

                int[] colsData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int row = 0; row < rows; row++)
                {
                    matrix[row, col] = colsData[row];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;

                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                    
                }
                Console.WriteLine(sum);
            }


            
            
        }
    }
}
