using System;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if (span > digits.Length)
        {
            throw new ArgumentException("The span can't be greater than the number of digits");
        }
        if (!digits.All(Char.IsDigit))
        {
            throw new ArgumentException("Digits must be a number");
        }
        if (span < 0 )
        { 
            throw new ArgumentException("Span can't be negative");
        }
        
        long max = 0;
        long product;
        for (int i=0; i <= digits.Length-span ; i++)
        {
            product = 1;
            for (int j=i; j<i+span; j++)
            {
                product*=(long)Char.GetNumericValue(digits[j]);
            }
            max = max > product ? max : product;
        }
        return max;
    }
}