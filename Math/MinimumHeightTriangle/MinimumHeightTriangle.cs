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
   * Complete the 'lowestTriangle' function below.
   *
   * The function is expected to return an INTEGER.
   * The function accepts following parameters:
   *  1. INTEGER trianglebase
   *  2. INTEGER area
   */

  public static int lowestTriangle(int baseOfTriangle, int minArea)
  {
    // Using the area of a triangle formula A = (base * height) / 2, solving for height gives us:
    // height = (2 * A) / base. Since we need the smallest integer height, we take the ceiling of the division.
    return (int)Math.Ceiling((double)(2 * minArea) / baseOfTriangle);
  }

}

class Solution
{
  public static void Main(string[] args)
  {
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int trianglebase = Convert.ToInt32(firstMultipleInput[0]);

    int area = Convert.ToInt32(firstMultipleInput[1]);

    int height = Result.lowestTriangle(trianglebase, area);

    textWriter.WriteLine(height);

    textWriter.Flush();
    textWriter.Close();
  }
}