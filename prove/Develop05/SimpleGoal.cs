
namespace EternalQuest
{
    // Class for simple goals
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
            DisplayAnimation();
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName}: {_description} - Points: {_points}";
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal;{_shortName};{_description};{_points};{_isComplete}";
        }

        private void DisplayAnimation()
        {
            Console.WriteLine("Goal Achieved!");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}
