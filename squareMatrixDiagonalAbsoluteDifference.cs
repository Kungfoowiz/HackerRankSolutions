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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(int squareSize, List<List<int>> numberMatrix)
    {
        var result = 0;

        var leftToRightDiagonal = 0;

        var rightToLeftDiagonal = 0;

        // Iterate the matrix.
        for (int index = 0; index < squareSize; index++)
        {
            // Add up the left diagonal.
            // Left diagonal follows the index.
            leftToRightDiagonal += numberMatrix[index][index];

            // Add up the right diagonal.
            // Right diagonal follows the matrix size - 1 - the index.
            rightToLeftDiagonal += numberMatrix[index][squareSize - 1 - index];
        }

        // Find the absolute value of subtracting the left and right diagonals.
        result = Math.Abs(leftToRightDiagonal - rightToLeftDiagonal);

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int result = 0;

        int squareSize = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> numberMatrix = new List<List<int>>();

        for (int index = 0; index < squareSize; index++)
        {
            numberMatrix.Add(
                Console.ReadLine()
                    .TrimEnd()
                    .Split(' ')
                    .ToList()
                    .Select(
                        arrayConversion => Convert.ToInt32(arrayConversion)
                    )
                    .ToList()
            );
        }

        result = Result.diagonalDifference(squareSize, numberMatrix);

        Console.WriteLine(result);
    }
}
