using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength > numbers.Length)
        { 
            throw new ArgumentException("Slice length can't be greater than the length of the string.");
        }
        if (sliceLength < 1)
        {
            throw new ArgumentException("Slice length must be at least 1.");
        }
        if (numbers == null)
        { 
            throw new ArgumentException("String can't be null.");
        }

        string[] slices = new string[numbers.Length - sliceLength + 1];
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            slices[i] = numbers.Substring(i,sliceLength);
        }
        return slices;
    }
}