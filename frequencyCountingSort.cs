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
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> countingSort(List<int> arrayToSort)
    {
        // Frequency array must handle numbers 0 .. 99, excluding 100.
        List<int> frequencyArray = new List<int>(new int[100]);

        foreach (var number in arrayToSort)
        {
            frequencyArray[number]++;
        }

        return frequencyArray;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int arraySize = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arrayElements = Console.ReadLine()
            .TrimEnd()
            .Split(' ')
            .ToList()
            .Select(arrayConvert => Convert.ToInt32(arrayConvert)).ToList();

        List<int> result = Result.countingSort(arrayElements);

        Console.WriteLine(String.Join(" ", result));
    }
}
