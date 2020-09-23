using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
private static int Month;
private static int Year;
    public Meetup(int month, int year)
    {
        Month = month;
        Year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        DateTime date = new DateTime(Year,Month,1);

        if (schedule == Schedule.Teenth)
        {
            for (int i=12; i<19; i++)
            {                    
                if (date.AddDays(i).DayOfWeek == dayOfWeek)
                {
                    return date.AddDays(i);
                }
            }
        }

        if (schedule == Schedule.Last)
        {
            date = new DateTime(date.Year,
                                    date.Month,
                                    DateTime.DaysInMonth(date.Year,date.Month));
            while (date.DayOfWeek != dayOfWeek)
            {
                date = date.AddDays(-1);
            }
            return date;
        }

        while (date.DayOfWeek != dayOfWeek)
        {
            date = date.AddDays(1);
        }
        date = date.AddDays(((int)schedule-1)*7);
        return date;
    }
}