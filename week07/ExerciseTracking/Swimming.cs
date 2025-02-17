using System;
using System.Collections.Generic;

// Swimming activity
class Swimming : Activity
{
    private int Laps;
    private const double LapDistance = 50.0 / 1000; // 50 meters per lap converted to km
    
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }
    
    public override double GetDistance() => Laps * LapDistance;
    public override double GetSpeed() => (GetDistance() / Duration) * 60;
    public override double GetPace() => Duration / GetDistance();
}