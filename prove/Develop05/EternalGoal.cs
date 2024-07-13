
namespace EternalQuest
{
    // Class for eternal goals
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            DisplayAnimation();
        }

        public override bool IsComplete()
        {
            return false; // Eternal goals are never complete
        }

        public override string GetDetailsString()
        {
            return $"{_shortName}: {_description} - Points: {_points} per event";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal;{_shortName};{_description};{_points}";
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
