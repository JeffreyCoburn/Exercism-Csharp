using System;

public enum Schedule
{
    First = 0,
    Second = 7,
    Third = 14,
    Fourth = 21,
    Teenth =22,
    Last = 23
}

public class Meetup
{
    private DateTime date;

    public Meetup(int month, int year)
    {
        date = new DateTime(year,month,1);
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        int offset = dayOfWeek - date.DayOfWeek;
        if (offset < 0) 
        {
            offset += 7;
        }
        offset++;

        int day;
        switch (schedule)
        {
            case Schedule.Teenth: 
                day = (offset+1)%7 + 13;
                break;
            case Schedule.Last:
                day = ((DateTime.DaysInMonth(date.Year,date.Month)-offset) / 7) * 7 + offset;
                break;
            default:
                day = offset + (int)schedule;
                break;
        }
        return new DateTime(date.Year,date.Month,day);
    }
}