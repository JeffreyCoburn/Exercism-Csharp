using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        for (char letter='A'; letter <='Z'; letter++)
        {
            if (!input.Contains(letter,StringComparison.OrdinalIgnoreCase)) { return false; }
        }
        return true;
    }
}
