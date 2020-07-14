using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> count =
            new Dictionary<char, int>()
            {
                { 'A', 0 },
                { 'C', 0 },
                { 'G', 0 },
                { 'T', 0 }
            };

        for (int i=0; i < sequence.Length; i++)
        {
            if (count.ContainsKey(sequence[i]))
                count[sequence[i]]++;
            else
                throw new ArgumentException("Invalid character in sequence."); 
        }
        return count;
    }
}