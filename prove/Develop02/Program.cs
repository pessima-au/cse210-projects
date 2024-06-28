using System;
using System.IO;

class Program
{
    //One of the challenges people have with writing jounals is that they 
    //often forget after a long day of work or simply been occupied with
    //other matters of the day. I have modified  the journal program to  
    //keep tract of streaks and to remind the user to fill their journal if they have not done so.

    //I have also added the ability to save files in cvs format and to open them in Excel.
    
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();


        promptGenerator.AddPrompt("Who was the most interesting person I interacted with today");
        promptGenerator.AddPrompt("What was the best part of my day?");
        promptGenerator.AddPrompt("How did I see the hand of the Lord in my life today?");
        promptGenerator.AddPrompt("What was the strongest emotion I felt today?");
        promptGenerator.AddPrompt("If I had one thing I could do over today, what would it be?");
        promptGenerator.AddPrompt("What was the highlight of your day?");


        bool running = true;

        while (running)
        {

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine($"Current streak: {journal.GetCurrentStreak()} days");

            if (!journal.IsEntryForToday())
            {
                Console.WriteLine("Reminder: You haven't written anything today. Keep up your streak!");
            }
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine("Prompt: What would youu like to  do?");
            //Console.ReadLine();

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    AddEntry(journal, promptGenerator);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    LoadJournal(journal);
                    break;
                case "4":
                    SaveJournal(journal);
                    break;
                case "5":
                    running = false;
                    break;
                    default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

            Console.WriteLine();
        }

    }

    static void AddEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Write your entry: ");
        string entryText = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry entry = new Entry(date, prompt, entryText);
        journal.AddEntry(entry);
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter the file path to save (e.g., journal.cvs):");
        string filePath = Console.ReadLine();
        journal.SaveToFile(filePath);
        Console.WriteLine("Entries saved successfully.");
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter the file path to load (e.g., journal.cvs): ");
        string filePath = Console.ReadLine();
        journal.LoadFromFile(filePath);
        Console.WriteLine("Entries loaded successfully.");
    }

}