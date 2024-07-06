
using System.Timers;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _usedPrompts;
    private List<string> _usedQuestions;


    public ReflectingActivity() :  base()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _usedPrompts = new List<string>();
        _usedQuestions = new List<string>();


        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayPrompt();
        Console.WriteLine("When you have something in mind press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowSpinner(5);

        int elapsed = 0;
        while (elapsed < _duration && _questions.Any())
        {
            DisplayQuestions();
            ShowSpinner(5);

            // Console.ReadLine();
            // elapsed += 5;
            // string response = Console.ReadLine();
            // if (response.ToLower() == "done")
            // {
            //     break;
            // }
            elapsed += 5;
        }
    }


    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }
          Random rand = new Random();
          int index = rand.Next(_prompts.Count);
          string prompt = _prompts[index];
          _prompts.RemoveAt(index);
          _usedPrompts.Add(prompt);
          return prompt;
    }
    public string GetRandomQuestion()
    {
       if (_questions.Count == 0)
        {
            _questions.AddRange(_usedQuestions);
            _usedQuestions.Clear();
        }
        Random random = new Random();
        int idx = random.Next(_questions.Count);
        string question = _questions[idx];
        _questions.RemoveAt(idx);
        _usedQuestions.Add(question);
        return question;
    }

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }

    public  void DisplayQuestions()
    {
        String randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
    }
}