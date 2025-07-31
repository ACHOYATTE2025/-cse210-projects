using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        0);
        List<string> prompts = ["Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."];
        

        List<string> questions = ["Why was this experience meaningful to you?",
                                "Have you ever done anything like this before?",
                                "How did you get started?",
                                "How did you feel when it was complete?",
                                "What made this time different than other times when you were not as successful?",
                                "What is your favorite thing about this experience?",
                                "What could you learn from this experience that applies to other situations?",
                                "What did you learn about yourself through this experience?",
                                "How can you keep this experience in mind in the future?"];

        ReflectingActivity reflectingActivity = new ReflectingActivity(prompts,questions);

        List<string> promptsListing = ["Who are people that you appreciate?",
                                        "What are personal strengths of yours?",
                                        "Who are people that you have helped this week?",
                                        "When have you felt the Holy Ghost this month?",
                                        "Who are some of your personal heroes?"];

        ListingActivity listingActivity = new ListingActivity("Listing of Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        ,0,0,promptsListing);


        int choice = 0;
        
        bool whiled = false;
        while (!whiled)
        { 
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start Reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
           

            try
            {
                Console.Write("Select a choice from the menu:");
                choice = int.Parse(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine("Wrong Entry, Try again ...");


            }
            

            switch (choice)
                {
                    case 1:
                        breathingActivity.Run();
                        ;
                        break;
                    case 2:
                        reflectingActivity.Run();
                        ;
                        break;
                    case 3:
                        listingActivity.Run();
                        ;
                        break;
                    case 4:
                        whiled = true;
                    Console.WriteLine("Bye........");
                        ;
                        break;
                    default: Console.Clear();
                        
                        break;
                }
        }
    }
}