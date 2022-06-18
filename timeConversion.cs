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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string timeAmPm)
    {
        var result = "";

        // Parse the time string into datetime and then format to 24 hours.
        result = DateTime.Parse(timeAmPm).ToString("HH:mm:ss");

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string timeAmPm = Console.ReadLine();

        string result = Result.timeConversion(timeAmPm);

        Console.WriteLine(result);
    }
}
