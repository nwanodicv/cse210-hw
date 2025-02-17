using System;
using System.Collections.Generic;

// Base class for activities
abstract class Activity
{
    public DateTime Date { get; set; }
    public int Duration { get; set; } // in minutes
    
    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }
    
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} ({Duration} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }
}