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
   * Complete the 'solve' function below.
   *
   * The function is expected to return a STRING.
   * The function accepts LONG_INTEGER n as parameter.
   */

  public static string solve(long n)
  {
    // We need to solve the equation m(m + 1)/2 = n for m
    // which simplifies to the quadratic equation m^2 + m - 2n = 0
    double discriminant = Math.Sqrt(1 + 8 * n);
    if (discriminant % 1 == 0) // Check if the discriminant is an integer
    {
      // Calculate the potential m value using the quadratic formula
      long m = (long)((-1 + discriminant) / 2);
      // Check if n is a triangular number by substituting m back into the triangular number formula
      if (m * (m + 1) / 2 == n)
      {
        // If it is a triangular number, return "Go On Bob" with the number of moves
        return $"Go On Bob {m}";
      }
    }   
    // If n is not a triangular number, it's not possible to reach that block
    return "Better Luck Next Time";
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

      string result = Result.solve(n);

      textWriter.WriteLine(result);
    }

    textWriter.Flush();
    textWriter.Close();
  }
}