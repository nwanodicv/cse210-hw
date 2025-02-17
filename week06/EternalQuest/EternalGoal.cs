using System;
using System.Collections.Generic;
using System.IO;

class EternalGoal : Goal
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override int RecordEvent()
    {
        return Points;
    }

    public override string GetStatus()
    {
        return "[∞]"; // Infinite progress indicator
    }

    public override string SaveData()
    {
        return $"EternalGoal,{Name},{Points}";
    }
}