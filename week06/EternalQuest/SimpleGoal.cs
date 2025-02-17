using System;
using System.Collections.Generic;
using System.IO;

// Simple goal that can be completed once
class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    public override string SaveData()
    {
        return $"SimpleGoal,{Name},{Points},{_isComplete}";
    }
}