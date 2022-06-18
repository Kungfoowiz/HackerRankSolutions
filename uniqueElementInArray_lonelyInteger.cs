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
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> arrayOfNumbers)
    {
        return 
            arrayOfNumbers
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key)
                .FirstOrDefault();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int totalNumbers = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arrayOfNumbers = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(arrayOfNumbers);

        Console.WriteLine(result);
    }
}
