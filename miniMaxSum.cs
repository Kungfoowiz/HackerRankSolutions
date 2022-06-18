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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arrayOfNumbers)
    {
        var minimumSum = 0.0;

        var maximumSum = 0.0;

        // Sort the number array.
        arrayOfNumbers.Sort();

        // Calculate the minimum sum.
        for (int index = 0; index < 4; index++)
        {
            try   
            {
                checked
                {
                    minimumSum += arrayOfNumbers[index];
                }
            }
            // Overflowed integer, just use the maximum integer then and break out.
            catch (OverflowException ex)
            {
                minimumSum = int.MaxValue;

                break;
            }
        }

        // Calculate the maximum sum.
        for (int index = 1; index < 5; index++)
        {
            try   
            {
                checked
                {
                    maximumSum += arrayOfNumbers[index];
                }
            }
            // Overflowed integer, just use the maximum integer then and break out.
            catch (OverflowException ex)
            {
                maximumSum = int.MaxValue;

                break;
            }
        }

        // Print out the minimum and maximum sums.
        Console.WriteLine($"{minimumSum} {maximumSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<long> arrayOfNumbers;

        // Console.Write("Enter 5 numbers separated by a space and then press ENTER? ");
        arrayOfNumbers = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(selectArray => Convert.ToInt64(selectArray)).ToList();

        Result.miniMaxSum(arrayOfNumbers);
    }
}
