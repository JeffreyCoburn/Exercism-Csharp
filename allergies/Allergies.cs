using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private Allergen score;
    public Allergies(int mask)
    {
        score = (Allergen)mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return score.HasFlag(allergen);
        //return (allergen & score) == allergen;
    }

    public Allergen[] List()
    {
        List<Allergen> list = new List<Allergen>();
        foreach (Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if (score.HasFlag(allergen)) 
            {
                list.Add(allergen);
            }
        }
        return list.ToArray();
    }
}