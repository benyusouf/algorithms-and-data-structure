/// <summary>
/// https://www.hackerrank.com/challenges/manasa-and-factorials
/// Manasa was sulking her way through a boring class when suddenly her teacher singled her out 
/// and asked her a question. He gave her a number n and Manasa has to come up with the smallest 
/// number m which contains atleast n number of zeros at the end of m!. Help Manasa come out of 
/// the sticky situation.
/// </summary>
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
     * Complete the 'solve' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */
     
    static long GetDifference(long n){
        long temp = n, count = 0;
        
        while(temp >= 5){
            temp = (temp/5);
            count += temp;
        }
        return count;
    }
    
    public static long solve(long n)
    {
        if(n > 5){
            long res = n*5-(n-(n%5));
            long deff = GetDifference(res);
            
            while(deff < n){
                res += 5;
                deff = GetDifference(res);
            }
            return res;
        }
        else{
            return n * 5;
        }
    }
    

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.solve(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
