using System;

public static class ResistorColor
{
    public static int ColorCode(string color) 
    {          
        color = color.ToLower();
        return (color=="black"? 0 
            : color=="brown" ? 1   
            : color=="red" ? 2 
            : color=="orange" ? 3 
            : color=="yellow" ? 4 
            : color=="green" ? 5
            : color=="blue" ? 6
            : color=="violet" ? 7
            : color=="grey" ? 8
            : color=="white" ? 9 : throw new Exception("Invalid color"));
    }

    public static string[] Colors() => (new string[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"});
}