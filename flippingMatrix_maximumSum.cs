using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     */

    // Discussion about how to solve this bugger.
    // https://www.hackerrank.com/challenges/flipping-the-matrix/forum

    
// seydahatipoglu 6 months ago
// After struggling for quite a bit of time, I came across to Ryan's solution in Java in Github: https://github.com/RyanFehr/HackerRank/blob/master/Algorithms/Constructve%20Algorithms/Flipping%20Matrix/Solution.java His solution is very easy to understand and implement:

// Every value at index(i,j) can get its value from either itself(i,j) or from (i,len-i-1), or (len-i-1,j), or (len-i-1,len-j-1) by rotating. So we just need to choose max of them for upper-left quadrant of the matrix given.

//  public static int flippingMatrix(List<List<int>> matrix)
//     {
//         var len=matrix.Count;
//         var half=len/2;
//         var sum=0;
        
//         for(int i=0;i<half;i++)
//         {
//             for(int j=0;j<half;j++)
//             {
//                 var value1=matrix[i][j];
//                 var value2=matrix[i][len-j-1];
//                 var value3=matrix[len-i-1][j];
//                 var value4=matrix[len-i-1][len-j-1];
//                 sum+=new int[]{value1,value2,value3,value4}.Max();
//             }
//         }
//         return sum;
//     }

    public static int flippingMatrix(int n, List<List<int>> matrix)
    {
        var shape = 0;

        var matrixWidth = matrix.Count;
        
        var halfMatrixWidth = matrixWidth / 2;
        
        var totalSum = 0;
        
        Console.WriteLine("DEBUG THE MATRIX ... ");
        
        Console.WriteLine($"Matrix is {matrixWidth} elements wide, and will have {matrixWidth} shapes to find maximum sums.");

        for(int row = 0; row < halfMatrixWidth; row++)
        {
            for(int column = 0; column < halfMatrixWidth; column++)
            {
                Console.WriteLine($"Matrix shape #{++shape} ...");
                
                // Console.WriteLine($"row [{row}]");
                // Console.WriteLine($"column [{column}]");
                
                var value1 = matrix[row][column];
                Console.WriteLine($"value1 [{value1}]");

                var value2 = matrix[row][matrixWidth - column -1];
                Console.WriteLine($"value2 [{value2}]");
                
                var value3 = matrix[matrixWidth - row - 1][column];
                Console.WriteLine($"value3 [{value3}]");
                
                var value4 = matrix[matrixWidth - row - 1][matrixWidth - column - 1];
                Console.WriteLine($"value4 [{value4}]");

                // Find the maximum value from this matrix shape?
                var maxValue = new int[]{value1, value2, value3, value4}.Max();
                Console.WriteLine($"maxValue [{maxValue}]");

                // Sum up that maximum value from the matrix shape.
                totalSum += maxValue;
            }

        }

        Console.WriteLine("END OF DEBUG THE MATRIX ... ");

        return totalSum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine($"n is equal to [{n}] so matrix is 2n [{2 * n}] by 2n [{2 * n}].");

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = Result.flippingMatrix(n, matrix);
            
            Console.WriteLine("Maximum sum from matrix reversals ...");
            Console.WriteLine(result);
        }

    }
}
