using System;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        // If string is empty, return true
        if (input.Length==0) { return true; }

        int endBracketIndex;
        // Check if the first character is a bracket
        switch (input[0]) {
            case '[':
                endBracketIndex = input.LastIndexOf(']');
                // If the matching end bracket can't be found, return false
                if (endBracketIndex == -1) { return false; };
                break;
            case '{':
                endBracketIndex = input.LastIndexOf('}');
                // If the matching end bracket can't be found, return false
                if (endBracketIndex == -1) { return false; };
                break;
            case '(':
                endBracketIndex = input.LastIndexOf(')');
                // If the matching end bracket can't be found, return false
                if (endBracketIndex == -1) { return false; };
                break;
            default:
                // Otherwise, strip off first char since it isn't a bracket, and check the next
                return IsPaired(input.Substring(1,input.Length-1));
           
        }
        // If the brackets match, check the string inside the bracket as well as the string after the end bracket (if there is any)
        if (endBracketIndex == input.Length - 1) {
            return IsPaired(input.Substring(1, endBracketIndex - 1));
        }
        return IsPaired(input.Substring(1, endBracketIndex - 1)) &&
                IsPaired(input.Substring(endBracketIndex + 1, input.Length - endBracketIndex - 1));
    }

}
