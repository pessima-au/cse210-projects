
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Wellcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...");
        ShowSpinner(4);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good Job!");
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i< seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}