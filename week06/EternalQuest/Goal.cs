using System;
using System.Collections.Generic;
using System.IO;

// Base class for all goals
abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string SaveData();
}