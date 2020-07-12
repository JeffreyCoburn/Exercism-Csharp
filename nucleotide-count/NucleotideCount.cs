using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> _Count =
            new Dictionary<char, int>();

        _Count.Add('A', 0);
        _Count.Add('C', 0);
        _Count.Add('G', 0);
        _Count.Add('T', 0);

        for (int i=0; i < sequence.Length; i++)
        {
            if (_Count.ContainsKey(sequence[i]))
                _Count[sequence[i]]++;
            else
                throw new ArgumentException("Invalid character in sequence."); 
        }
        return _Count;
    }
}