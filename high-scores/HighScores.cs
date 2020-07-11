using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _scores;

    public HighScores(List<int> list)
    {
        _scores=list;
    }

    public IEnumerable<int> Scores() => _scores;

    public int Latest() => _scores.Last();

    public int PersonalBest() => _scores.Max();

    public IEnumerable<int> PersonalTopThree() => _scores.OrderByDescending(x=>x).Take(3).ToList();
}