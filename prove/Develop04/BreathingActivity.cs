
public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        int halfDuration = _duration / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Breath in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
    }

}