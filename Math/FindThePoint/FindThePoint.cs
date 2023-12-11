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
   * Complete the 'findPoint' function below.
   *
   * The function is expected to return an INTEGER_ARRAY.
   * The function accepts following parameters:
   *  1. INTEGER px
   *  2. INTEGER py
   *  3. INTEGER qx
   *  4. INTEGER qy
   */

  public static List<int> findPoint(int px, int py, int qx, int qy)
  {
    int x = 2*qx - px;
    int y = 2*qy - py;
    return new List<int>{x,y};
  }

}

class Solution
{
  public static void Main(string[] args)
  {
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    int n = Convert.ToInt32(Console.ReadLine().Trim());

    for (int nItr = 0; nItr < n; nItr++)
    {
      string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

      int px = Convert.ToInt32(firstMultipleInput[0]);

      int py = Convert.ToInt32(firstMultipleInput[1]);

      int qx = Convert.ToInt32(firstMultipleInput[2]);

      int qy = Convert.ToInt32(firstMultipleInput[3]);

      List<int> result = Result.findPoint(px, py, qx, qy);

      textWriter.WriteLine(String.Join(" ", result));
    }

    textWriter.Flush();
    textWriter.Close();
  }
}