using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {        
        if (max < 1)
        {
            throw new ArgumentOutOfRangeException("max");
        }
        int value = max - 1;
        int sum = 0;
        while (value > 0)
        {
            foreach (int multiple in multiples)
            {
                if (multiple == 0) 
                { 
                    break;
                }
                if (value % multiple == 0)
                {
                    sum += value;
                    break;
                }
            }
            value--;
        }
        return sum;
    }
}