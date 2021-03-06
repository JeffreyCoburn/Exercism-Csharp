using System;

public struct Clock : IEquatable<Clock>
{
    private const int MinutesInOneDay = 24 *60;
    public int Minutes { get; }

    public Clock(int hours, int minutes)
    {       
        minutes += (hours * 60);
        minutes = minutes % MinutesInOneDay;
        if (minutes < 0 )
        {
            minutes = minutes + MinutesInOneDay;
        }
        Minutes = minutes;
    }

    public Clock Add(int minutesToAdd) => new Clock (0, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => Add(minutesToSubtract * -1);

    public override string ToString()
    {
        int hours = Minutes / 60;
        int minutes = Minutes % 60;
        return ($"{hours:D2}:{minutes:D2}");
    }

    public bool Equals(Clock clock) => this.Minutes == clock.Minutes;
}
