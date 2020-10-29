using System;
using System.Collections.Generic;
using System.Linq;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2 || outputBase <2) { throw new ArgumentException("Base can't be less than 2"); }
        if (inputDigits.Any(c => c >= inputBase)) { throw new ArgumentException("Digits can't be greater than or equal to the base"); }
        if (inputDigits.Any(c => c<0)) { throw new ArgumentException("Digits can't be negative"); }
        if (inputDigits.Length == 0) { return new int[] {0}; }

        int number = 0;
        for (int i = 0; i < inputDigits.Length; i++) {
            number += inputDigits[i] * Convert.ToInt32(Math.Pow(inputBase, inputDigits.Length - 1 - i));
        }
        
        if (number == 0) { return new int[] {0}; }

        List<int> outputDigits = new List<int>();
        while (number > 0) {
            outputDigits.Add(number % outputBase);
            number /= outputBase;
        }
        outputDigits.Reverse();

        return outputDigits.ToArray();
    }
}