using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> factors = new List<long>();
        long divisor = 2;
        while (number != 1)
        {
            if (number % divisor == 0)
            {
                number /= divisor;
                factors.Add(divisor);
            }
            else
            {
                divisor++;
            }
        }
        return factors.ToArray();
    }
}