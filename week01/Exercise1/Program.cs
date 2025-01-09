using System;

class Program
{
    static void Main(string[] args)// Main
    {
        Console.WriteLine("");// This is for empty line

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();// Prompt user to add first name
        Console.Write("what is your last name? ");
        string lastName = Console.ReadLine();// Prompt user to add last name

        Console.WriteLine("");// This is for empty line
        // This displays user input on the screen
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        
        Console.WriteLine("");// This is for empty line
        
    }
}