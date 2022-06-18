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

    public static void plusMinus(int totalNumbers, List<int> arrayOfNumbers)
    {
        var totalPositives = 0;
        var proportionOfPositives = "";

        var totalNegatives = 0;
        var proportionOfNegatives = "";

        var totalZeroes = 0;
        var proportionOfZeroes = "";

        // Iterate the array and tally up the totals
        // for each category of number.
        foreach (var item in arrayOfNumbers){
            if( item > 0 )
                totalPositives++;
            else if( item < 0 )
                totalNegatives++;
            else
                totalZeroes++;
        }

        // Work out the ratio for each category of number.
        // Prevent division by zero.
        if (totalNumbers != 0){
            proportionOfPositives = String.Format("{0:0.000000}", Math.Round((double) totalPositives / totalNumbers, 6));
            proportionOfNegatives = String.Format("{0:0.000000}", Math.Round((double) totalNegatives / totalNumbers, 6));
            proportionOfZeroes = String.Format("{0:0.000000}", Math.Round((double) totalZeroes / totalNumbers, 6));
        }

        // Print out the number category ratios.
        Console.WriteLine(proportionOfPositives);
        Console.WriteLine(proportionOfNegatives);
        Console.WriteLine(proportionOfZeroes);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        var totalNumbers = 0;

        List<int> arrayOfNumbers;

        // Console.Write("Enter the total number of numbers and press ENTER? ");
        totalNumbers = Convert.ToInt32(Console.ReadLine().Trim());

        // Console.Write("Enter each number separated by a space and then press ENTER? ");
        arrayOfNumbers = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(selectArray => Convert.ToInt32(selectArray)).ToList();

        Result.plusMinus(totalNumbers, arrayOfNumbers);
    }
}
