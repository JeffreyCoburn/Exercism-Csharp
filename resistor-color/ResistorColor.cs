﻿using System;

public static class ResistorColor
{
    public static int ColorCode(string color) 
    {          
        color = color.ToLower();
        return Array.IndexOf(Colors(),color);
    }

    public static string[] Colors() => (new string[] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"});
}