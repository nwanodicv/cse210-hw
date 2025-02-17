using System;
using System.Collections.Generic;
using System.IO;

// Checklist goal that needs to be recorded multiple times
class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; private set; }
    public int BonusPoints { get; set; }
    
    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
    {
        Name = name;
        Points = points;
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override int RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            return (CurrentCount == TargetCount) ? Points + BonusPoints : Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return CurrentCount >= TargetCount ? "[X]" : $"[{CurrentCount}/{TargetCount}]";
    }

    public override string SaveData()
    {
        return $"ChecklistGoal,{Name},{Points},{TargetCount},{BonusPoints},{CurrentCount}";
    }
}
