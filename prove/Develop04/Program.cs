using System;
using System.Net;


// I have added creativity to ensure that prompts and questions are not reapeated 
// until all prompts and questions in the list are exhausted. I accomplished this by 
// adding the 'usedPrompts' and 'usedQuestions' attributes in the ReflectingActivity.
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu");
        
            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activity.DisplayStartingMessage();
                    ((BreathingActivity)activity).Run();
                    activity.DisplayEndingMessage();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    activity.DisplayStartingMessage();
                    ((ReflectingActivity)activity).Run();
                    activity.DisplayEndingMessage();
                    break;
                case "3":
                    activity = new ListingActivity();
                    activity.DisplayStartingMessage();
                    ((ListingActivity)activity).Run();
                    activity.DisplayEndingMessage();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
            }
        }
        
    }
}