using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (String.IsNullOrWhiteSpace(statement)) {
            return "Fine. Be that way!";
        }

        bool isYelling = statement.Any(char.IsLetter) && statement.Where(char.IsLetter).All(char.IsUpper);
        bool isQuestion = statement.TrimEnd().EndsWith('?');

        if (isYelling && isQuestion) {
            return "Calm down, I know what I'm doing!";
        }
        
        if (isQuestion) {
            return "Sure.";
        }
        
        if (isYelling) {
            return "Whoa, chill out!";
        }
        return "Whatever.";
    }
}