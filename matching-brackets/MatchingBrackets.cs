using System;
using System.Collections.Generic;

public static class MatchingBrackets
{
    private static Dictionary<char, char> brackets = new Dictionary<char, char> {
        {']', '['},
        {'}', '{'},
        {')', '('}
    };

    public static bool IsPaired(string input)
    {        
        Stack<char> startingBrackets = new Stack<char>();

        for (int i=0; i < input.Length; i++) {
            if ( brackets.ContainsValue(input[i])) { startingBrackets.Push(input[i]); };
            if ( brackets.ContainsKey(input[i]) && ((startingBrackets.Count == 0) || (startingBrackets.Pop() != brackets[input[i]]))) {
                return false; 
            }
        }

        // If stack is empty, that means every starting bracket had an ending bracket
        if (startingBrackets.Count == 0) { return true; }
        return false;

        
    }

}
