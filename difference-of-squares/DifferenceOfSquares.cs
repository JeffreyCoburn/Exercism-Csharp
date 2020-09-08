using System;
using System.Linq;
using System.Threading.Tasks;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max) => (int) Math.Pow(Enumerable.Range(1,max).Sum(),2);

    public static int CalculateSumOfSquares(int max)
    {
        /* Parallel was slower
        int result = 0;
        Parallel.ForEach(Enumerable.Range(1,max).ToArray(), 
                                        x => result += (int) Math.Pow(x,2));
        return result; */
        return (int) Enumerable.Range(1,max).Select(x => Math.Pow(x,2)).Sum();
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}