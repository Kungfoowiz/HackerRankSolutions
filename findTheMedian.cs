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
     * Complete the 'findMedian' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int findMedian(int totalNumbers, List<int> arrayOfNumbers)
    {
        var result = 0;

        // Find the mediaun index.
        int medianIndex = (totalNumbers - 1) / 2;

        // Sort the array of numbers.
        arrayOfNumbers.Sort();

        // Get the median number.
        result = arrayOfNumbers[medianIndex];

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int totalNumbers = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arrayOfNumbers = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.findMedian(totalNumbers, arrayOfNumbers);

        Console.WriteLine(result);
    }
}
