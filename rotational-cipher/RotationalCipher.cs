using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string output = "";
        foreach (char c in text)
        {
            output += Cipher(c,shiftKey);
        }
        return output;
    }
    private static char Cipher(char c, int shiftKey)
    {
        if (!char.IsLetter(c))
        {
            return c;
        }

	    char offset = char.IsUpper(c) ? 'A' : 'a';
	    return (char)(((c + shiftKey - offset) % 26) + offset); 
    }
}