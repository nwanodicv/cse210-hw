using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Mindfulness;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start breathing activity");
         Console.WriteLine("  2. Start listing activity");
        Console.WriteLine("   3. Start reflecting activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the menu ");
        string Option = Console.ReadLine();

        
        MindfulnessPro BreathingActivity = new MindfulnessPro();
        if (Option == "1")
        {
            BreathingActivity.StartBreathingSession();
            Console.WriteLine(BreathingActivity);

        }

        MindfulnessPro BreathingActivity2 = new MindfulnessPro();
        if (Option == "2")
        {
            BreathingActivity2.ListingActivity();
            Console.WriteLine(BreathingActivity2);
        }

        MindfulnessPro BreathingActivity3 = new MindfulnessPro();
        if (Option == "3")
        {
            BreathingActivity2.ReflectionActivity();
            Console.WriteLine(BreathingActivity2);
        }

        MindfulnessPro BreathingActivity4 = new MindfulnessPro();
        if (Option == "4")
        {
            BreathingActivity2.EndSession();
            Console.WriteLine(BreathingActivity2);
        }
       

    }
}