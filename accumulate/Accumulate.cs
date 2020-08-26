using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        ICollection<U> results = new List<U>();
        foreach (T item in collection)
        {
            results.Add(func(item));
        }
        return results;
    }
}