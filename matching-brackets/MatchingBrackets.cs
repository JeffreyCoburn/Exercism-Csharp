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
            if ( brackets.ContainsValue(input[i])) { startingBrackets.Push(input[i]); continue; };
            if ( brackets.ContainsKey(input[i])) {
                // If the stack is empty, there is an ending bracket with no starting bracket
                if (startingBrackets.Count == 0) { return false; }
                // Check if the ending bracket matches the last starting bracket
                if (startingBrackets.Pop() != brackets[input[i]]) { return false; };
            }
        }

        // If stack is empty, that means every starting bracket had an ending bracket
        if (startingBrackets.Count == 0) { return true; }
        return false;

        
    }

}
