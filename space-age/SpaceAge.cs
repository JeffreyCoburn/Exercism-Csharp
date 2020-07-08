using System;

public class SpaceAge
{
    double earthYears;

    public SpaceAge(int seconds)
    {
        earthYears = seconds/31557600.0;
    }

    public double OnEarth() => earthYears;

    public double OnMercury() => earthYears/0.2408467;

    public double OnVenus() => earthYears/0.61519726;

    public double OnMars() => earthYears/1.8808158;

    public double OnJupiter() => earthYears/11.862615;

    public double OnSaturn() => earthYears/29.447498;

    public double OnUranus() => earthYears/84.016846;

    public double OnNeptune() => earthYears/164.79132;
}