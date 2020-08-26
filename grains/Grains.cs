using System;

public static class Grains
{
    private const int maxSquares = 64;
    private static ulong totalGrains = (ulong)Math.Pow(2,maxSquares)-1;
    public static ulong Square(int n)
    {
        if (n < 1 || n > maxSquares)
        {
            throw new ArgumentOutOfRangeException(nameof(n));
        }
        return (ulong)Math.Pow(2,n-1);
    }

    public static ulong Total() => totalGrains;
}