
public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts;

    public ListingActivity() : base()
    {
         _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
          };

         _name = "Listing";

        _count = 0;
        
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
    }
    public void Run()
    {
       DisplayPrompt();
       ShowSpinner(5);

       List<string> userResponses = GetListFromUser(_duration);
       Console.WriteLine($"You listed {userResponses.Count} items.");
    }

    public string GetRandomPrompt()
    {
         Random random = new Random();
        int idx = random.Next(_prompts.Count);
        return _prompts[idx];
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> userPrompts = new List<string>();
        Console.WriteLine("List as many responses as you can to the following prompts:");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                {
                    break;
                }
                userPrompts.Add(input);
            }
        }
        return userPrompts;
    }
}