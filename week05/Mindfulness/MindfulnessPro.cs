using System;
using System.Security.Cryptography.X509Certificates;

namespace Mindfulness
{
    public class MindfulnessPro
    {
        public void StartBreathingSession()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to breathing activity");
            Console.WriteLine();

            //This is my exceeding requirement, it allow the user to enter firstName and LastName
            Console.Write("Enter your first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Discription: This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session?: ");
            string Seconds = Console.ReadLine();

            int UserSessionTime = int.Parse(Seconds);
            Console.WriteLine("Get ready...");

            int i = 0;

            if (i <= UserSessionTime || i >= UserSessionTime)
            {
                List<string> AnimationStrings = new List<string>();
                AnimationStrings.Add("|");
                AnimationStrings.Add("/");
                AnimationStrings.Add("-");
                AnimationStrings.Add("\\");
                AnimationStrings.Add("|");
                AnimationStrings.Add("/");
                AnimationStrings.Add("-");
                AnimationStrings.Add("\\");
                

                DateTime StartTime = DateTime.Now;
                DateTime EndTime = StartTime.AddSeconds(5);

                int a = 0;

                while (DateTime.Now < EndTime)
                {
                    string s = AnimationStrings[a];
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");

                    a++;

                    if (a >= AnimationStrings.Count)
                    {
                        a = 0;
                    }
                }

                List<string> BreathIn = new List<string>();
                BreathIn.Add("Breath In...");
                BreathIn.Add("Breath Out...");
                BreathIn.Add("Breath In...");
                BreathIn.Add("Breath Out...");
                BreathIn.Add("Breath In...");
                BreathIn.Add("Breath Out...");

                List<string> BreathOut = new List<string>();
                BreathOut.Add("Breath Out...");

                foreach (string breath in BreathIn)
                {
                    Console.Write($"{breath}\n");
                    int j = 0;
                    for (j = 5; j > 0; j--)
                    {
                        Console.Write($"{j}");
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }
                }
                //My exceeding requirement, this displays the user' firstName and lastName on the screen!
                Console.Write($"Good Job! Mr/Mrs {FirstName} {LastName}!");
            }
        }


        public void ListingActivity()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to listing activity");
            Console.WriteLine();

            //This is my exceeding requirement, it allow the user to enter firstName and LastName
            Console.Write("Enter your first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Discription: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session?: ");
            string Seconds = Console.ReadLine();

            int UserSessionTime = int.Parse(Seconds);
            Console.WriteLine("Get ready...");

            List<string> UserResponseList = new List<string>();
            int i = 0;

            if (i <= UserSessionTime || i >= UserSessionTime)
            {
                Console.WriteLine("Who are people that you appreciate?");
                string UserResponse1 = Console.ReadLine();
                Thread.Sleep(3000);
                Console.WriteLine();

                Console.WriteLine("What are personal strengths of yours?");
                string UserResponse2 = Console.ReadLine();
                Thread.Sleep(10000);
                Console.WriteLine();

                Console.WriteLine("Who are people that you have helped this week?");
                string UserResponse3 = Console.ReadLine();
                Thread.Sleep(10000);
                Console.WriteLine();

                Console.WriteLine("When have you felt the Holy Ghost this month?");
                string UserResponse4 = Console.ReadLine();
                Thread.Sleep(10000);
                Console.WriteLine();

                Console.WriteLine("Who are some of your personal heroes?");
                string UserResponse5 = Console.ReadLine();
                Thread.Sleep(10000);
                Console.WriteLine();

                UserResponseList.Add(UserResponse1);
                UserResponseList.Add(UserResponse2);
                UserResponseList.Add(UserResponse3);
                UserResponseList.Add(UserResponse4);
                UserResponseList.Add(UserResponse5);

            }

            Console.Write($"You responded {UserResponseList.Count} times!\n");
            //My exceeding requirement, this displays the user' firstName and lastName on the screen!
            Console.Write($"Good Job! Mr/Mrs {FirstName} {LastName}!\n");
            Console.WriteLine();
            
        }



        public void ReflectionActivity()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Reflection activity");
            Console.WriteLine();

            //This is my exceeding requirement, it allow the user to enter firstName and LastName
            Console.Write("Enter your first name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Discription: his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session?: ");
            string Seconds = Console.ReadLine();

            int UserSessionTime = int.Parse(Seconds);
            Console.WriteLine("Get ready...");

            List<string> UserResponseList = new List<string>();
            int i = 0;

            if (i <= UserSessionTime || i >= UserSessionTime)
            {
                Console.WriteLine("Think of a time when you stood up for someone else.");
                Thread.Sleep(4000);
                Console.WriteLine();

                Console.WriteLine("Think of a time when you did something really difficult.");
                Thread.Sleep(4000);
                Console.WriteLine();
                
                Console.WriteLine("Think of a time when you helped someone in need.");
                Thread.Sleep(4000);
                Console.WriteLine();

                Console.WriteLine("Think of a time when you did something truly selfless.");
                Thread.Sleep(4000);
                Console.WriteLine();
            }   
            Console.WriteLine();
            Console.WriteLine($"Hello Mr./Mrs. {FirstName} {LastName} Reflect on the following questions that relate to this experience.");
            Console.WriteLine();
            List<string> RelatedExperience = new List<string>();
            RelatedExperience.Add("-Why was this experience meaningful to you?");
            RelatedExperience.Add("-Have you ever done anything like this before?");
            RelatedExperience.Add("-How did you get started?");
            RelatedExperience.Add("-How did you feel when it was complete?");
            RelatedExperience.Add("-What made this time different than other times when you were not as successful?");
            RelatedExperience.Add("-What is your favorite thing about this experience?");
            RelatedExperience.Add("-What could you learn from this experience that applies to other situations?");
            RelatedExperience.Add("-What did you learn about yourself through this experience?");
            RelatedExperience.Add("-How can you keep this experience in mind in the future?");

            foreach (string r in RelatedExperience)
            {
                
                Console.WriteLine(r);
                Thread.Sleep(3000);
                Console.Write("\b \b");

                List<string> AnimationStrings = new List<string>();
                AnimationStrings.Add("|");
                AnimationStrings.Add("/");
                AnimationStrings.Add("-");
                AnimationStrings.Add("\\");
                AnimationStrings.Add("|");
                AnimationStrings.Add("/");
                AnimationStrings.Add("-");
                AnimationStrings.Add("\\");


                DateTime StartTime = DateTime.Now;
                DateTime EndTime = StartTime.AddSeconds(15);

                int a = 0;

                while (DateTime.Now < EndTime)
                {
                    string s = AnimationStrings[a];
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b");

                    a++;

                    if (a >= AnimationStrings.Count)
                    {
                        a = 0;
                    }
                }
                
            }
            //My exceeding requirement, this displays the user' firstName and lastName on the screen!
            Console.Write($"Good Job! Mr/Mrs {FirstName} {LastName}!");
            Console.WriteLine();
            
        }

        public void EndSession()
        {
            Console.WriteLine("Ending mindfulness session...");
            Thread.Sleep(2000);
            Console.WriteLine("Good Job!");
            // Add more functionality here
        }
    }
}
