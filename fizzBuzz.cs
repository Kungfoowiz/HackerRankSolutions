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
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int finalIndex)
    {
        for (int index = 1; index <= finalIndex; index++)
        {
            var result = "";

            bool multipleOfThree = index % 3 == 0;

            bool multipleOfFive = index % 5 == 0;

            // Multiple of 3? Then print Fizz.
            if (multipleOfThree)
            {
                result += "Fizz";
            }

            // Multiple of 5? Then print Buzz.
            if (multipleOfFive)
            {
                result += "Buzz";
            }

            // Neither? Then print the number.
            if (multipleOfThree == false & multipleOfFive == false)
            {
                result = index.ToString();
            }

            // Output the result.
            Console.WriteLine(result);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int finalIndex = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(finalIndex);
    }
}
