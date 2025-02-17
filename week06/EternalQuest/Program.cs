using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    // Main program execution
class Program
{
    static void Main()
    {
        // My exceeding requirement
        Console.WriteLine("Welcome to goal creator");
        Console.WriteLine("Description: We will help you create a goal, record event, show your goals and save your goal");
        GoalManager manager = new GoalManager();
        manager.LoadGoals();

        while (true)
        {
            Console.WriteLine("1) Create Goal\n2) Record Event\n3) Show Goals\n4) Save & Exit");
            Console.Write("Enter your choice from the menu above: ");
            string choice = Console.ReadLine();
            if (choice == "1") manager.CreateGoal();
            else if (choice == "2") manager.RecordEvent();
            else if (choice == "3") manager.DisplayGoals();
            else if (choice == "4") { manager.SaveGoals(); break; }
        }
    }
}

}