using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

  /*
   * Complete the 'gameWithCells' function below.
   *
   * The function is expected to return an INTEGER.
   * The function accepts following parameters:
   *  1. INTEGER n
   *  2. INTEGER m
   */

  public static int gameWithCells(int n, int m)
  {
    // Calculate the number of drops required for the rows and columns
    // by dividing by 2 and rounding up, as one package can supply
    // a 2x2 area.
    int nDrops = (n + 1) / 2;
    int mDrops = (m + 1) / 2;
        
    // The total number of packages is the product of the two
    return nDrops * mDrops;
  }

}

class Solution
{
  public static void Main(string[] args)
  {
    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    int n = Convert.ToInt32(firstMultipleInput[0]);

    int m = Convert.ToInt32(firstMultipleInput[1]);

    int result = Result.gameWithCells(n, m);

    textWriter.WriteLine(result);

    textWriter.Flush();
    textWriter.Close();
  }
}