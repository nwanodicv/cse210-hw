using System;
using System.Collections.Generic;
using System.IO;


// Manages goals and user interactions
class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;
    private string filePath = "goals.txt";

    public void CreateGoal()
    {

        Console.WriteLine("Choose goal type:\n 1) Simple\n 2) Eternal\n 3) Checklist");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points per completion: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
        }
    }

    public void RecordEvent()
    {
        
        DisplayGoals();
        Console.Write("Select goal to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            totalScore += goals[index].RecordEvent();
            Console.WriteLine("Progress recorded!");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].Name}");
        }
        Console.WriteLine($"Total Score: {totalScore}\n");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(totalScore);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SaveData());
            }
        }
        Console.WriteLine("Goals saved!");
    }

    public void LoadGoals()
    {
        if (File.Exists(filePath))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines(filePath);
            totalScore = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])));
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                        break;
                    case "ChecklistGoal":
                        goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4])));
                        break;
                }
            }
            Console.WriteLine("Goals loaded!");
        }
    }
}